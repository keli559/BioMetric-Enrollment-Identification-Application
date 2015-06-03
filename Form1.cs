using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
//using System.Web;
using System.Windows.Forms;
using Microsoft.Win32;
using BioKey.WebKey;
using System.Diagnostics;
using WebKeyClientLib;
using AxWebKeyClientLib;

namespace WebKeySingleScan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // define the size of the bio-key image
            webkey.Size = new System.Drawing.Size(320, 145);
        }
        //Global Variables
        //-------------------------------------------------------------------------------      
        
        
        string connectionString;
        SqlConnection cnn;
        int _siteID = 20008;
        private bool _isAliasSearch = false;
        private bool _doAliasCheckOnEnroll = false;
        private String _adminID = "adminID";
        private String _baseURL = "http://octethp:8097/WEB-key/Main";
        string serverName = "acer2";
        string databaseName = "Odin";
        string WebkeyOperation;
        int currentIndex = -1;
        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lblEnrolled.Hide();
            //-----------------------------Test Connection-----------------------------
            connectionString = @"Server=" + serverName + 
                ";Database=" + databaseName + ";User ID=odin;Password=nidoict9999";
            //connectionString = "Server= ACER2;Database=Odin1;Trusted_Connection=True" ';User ID=UserName;Password=Password
            Debug.WriteLine(connectionString);
            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                statusstatuslblResults.Text = "Connected";
            }
            catch (Exception ex)
            {
                StatusStripResults.Text = "No Connection";
            }
            //'-----------------------------Load the student locator-----------------------------
            //' Dim con As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=<your db>;User ID=<your user>;Password=<your password>;")

            String querystrg;

            querystrg = "SELECT id_number, last_name, student FROM " + databaseName + ".Odin.student";
            //Debug.WriteLine(querystrg);

            //DataAdapter1 = new SqlDataAdapter(querystrg, cnn);
            //SqlCommandBuilder sql = new SqlCommandBuilder(DataAdapter1);

            //// this line would report error 
            //// if querystg sql command doesn't work.
            //DataAdapter1.Fill(stud_Data);

            //DataRow MyDataRow = stud_Data.NewRow();

            LoadTableMssql(querystrg);

            string strLastName;
            string strStudent;
            string strIdNumber;

            strIdNumber = "id_number".ToString();
            strLastName = "last_name".ToString();
            strStudent = "student".ToString();

            LastNameTextBox.Text = strLastName;
            FirstNameTextBox.Text = strStudent;
            IdTextBox.Text = strIdNumber;


            //StudentsDataGridView.DataSource = MyDataRow.Table;
            //// take off the first column of white margin
            //StudentsDataGridView.RowHeadersVisible = false;
            //// fill the box with selected data columns
            //StudentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        } // End of "MainForm_Load"

        private void button1_Click(object sender, EventArgs e) // enrollment buttons
        {
            int indx;
            indx = StudentsDataGridView.CurrentRow.Index;
            string _PersonID = (String)StudentsDataGridView[0, indx].Value;
            string _FirstName = (String)StudentsDataGridView[2, indx].Value;
            string _LastName = (String)StudentsDataGridView[1, indx].Value;
            BioKey.WebKey.Server server = new BioKey.WebKey.Server(_baseURL, 0, 0);
            server.NewPersonID = _PersonID;
            server.SiteID = _siteID;

            Enrollment(_PersonID, _FirstName, _LastName);
        } // end of enrollment buttons

        private void Enrollment(string _PersonID, string _FirstName, string _LastName)
        {
            lblEnrolled.Hide();
            BioKey.WebKey.Server server = new BioKey.WebKey.Server(_baseURL, 0, 0);
            statusstatuslblResults.Text = "Enrolling " + _FirstName + " " + _LastName + " (" + _PersonID + ") ...";
            server.PersonID = _PersonID;
            server.SiteID = _siteID;
            // no requirement to re confirm the enrollment code
            // if enrollment code is set to be: 0000...000
            server.EnrollmentCode = "0000000000000000000000000000";
            server.AddPerson(_adminID);


            int retVal = webkey.Init(_baseURL, 0, 0, "");
            webkey.Visible = true;
            webkey.SiteID = _siteID;
            webkey.PersonID = _PersonID;
            webkey.PersonIDFlag = BioKey.WebKey.AuthenticationMethod.IdentifiyOnServer;
            retVal = webkey.EnrollmentStart();
            WebkeyOperation = "enrollment";
        }

        private void IdentificationButton_Click(object sender, EventArgs e)
        {
            Identification();
        }

        private void Identification()
        {
            lblEnrolled.Hide();
            statusstatuslblResults.Text = "";
            int retVal = webkey.Init(_baseURL, 0, 0, "");
            if (retVal != 0)
            {
                statusstatuslblResults.Text = webkey.LastErrorMessage;
                return;
            }
            webkey.Visible = true;
            webkey.SiteID = _siteID;

            webkey.PersonIDFlag = BioKey.WebKey.AuthenticationMethod.IdentifiyOnServer;
            retVal = webkey.IdentificationStart();
            WebkeyOperation = "identification";
        }

        private void webkey_Notify(object sender, AxWebKeyClientLib._IWebKeyAppCtrlEvents_NotifyEvent e)
        {
            string querystrg;
            SqlDataAdapter DataAdapter1;
            DataTable stud_Data = new DataTable();
            MessageBox.Show(e.personID.ToString());
            if (e.errorCode == 0)
            {
                if (WebkeyOperation == "identification")
                {
                    //MessageBox.Show(e.personID);
                    //-------------------------------------------------------------------
                    // find index of selected row from data table 

                    querystrg = "SELECT id_number, last_name, student FROM " + databaseName + ".Odin.student order by last_name;";
                    DataAdapter1 = new SqlDataAdapter(querystrg, cnn);
                    SqlCommandBuilder sql = new SqlCommandBuilder(DataAdapter1);
                    // this line would report error 
                    // if querystg sql command doesn't work.
                    DataAdapter1.Fill(stud_Data);
                    DataRow[] testrow = stud_Data.Select("id_number = '" + e.personID + "'");
                    StudentsDataGridView.DataSource = testrow[0].Table;
                    currentIndex = stud_Data.Rows.IndexOf(testrow[0]);
                    //

                    //
                    //
                    IdTextBox.Text = testrow[0]["id_number"].ToString();
                    FirstNameTextBox.Text = testrow[0]["student"].ToString();
                    LastNameTextBox.Text = testrow[0]["last_name"].ToString();
                    loadPhoto(IdTextBox.Text);
                    //
                    //
                    // adjust the current row to be in the upper middle position
                    // of the DataGridView
                    StudentsDataGridView.FirstDisplayedScrollingRowIndex = Math.Max(currentIndex - 2, 0);
                    StudentsDataGridView.Rows[currentIndex].Selected = true;
                }
                else if (WebkeyOperation == "enrollment")
                {
                    currentIndex = StudentsDataGridView.CurrentRow.Index;
                    e.personID = (String)StudentsDataGridView[0, currentIndex].Value;
                    statusstatuslblResults.Text = "Welcome, " + e.personID + "!";
                    lblEnrolled.Show();
                    // adjust the current row to be in the upper middle position
                    // of the DataGridView
                    StudentsDataGridView.FirstDisplayedScrollingRowIndex = Math.Max(currentIndex - 2, 0);
                    StudentsDataGridView.Rows[currentIndex].Selected = true;
                }
                else
                {
                    // do nothing.
                }
            }
            else
            {
                statusstatuslblResults.Text = "Operation failed: " + webkey.LastErrorMessage;
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(cnn.State== ConnectionState.Open)
            //{
            //    cnn.Close();
            //}
            //cnn.Dispose();
            Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void StudentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indx;

            indx = StudentsDataGridView.CurrentRow.Index;

            IdTextBox.Text = (String)StudentsDataGridView[0, indx].Value;
            FirstNameTextBox.Text = (String)StudentsDataGridView[1, indx].Value;
            LastNameTextBox.Text = (String)StudentsDataGridView[2, indx].Value;

            loadPhoto(IdTextBox.Text);

            StudentsDataGridView.CurrentRow.Selected = true;
        }
        private void loadPhoto(string id_number)
        {
            //-----------------------------Load Photos-----------------------------
            //Once student is selected, Displays the student Photo, Student Name and Student ID on the right
            string photopath = "K:\\Curly\\TestingApps\\WebKeySingleScan\\StudentsPhotos";//SettingsForm.txtPhotoPath.Text;
            if (File.Exists(photopath + "\\" + id_number + ".jpg"))
                StudentPictureBox.Image = Image.FromFile(photopath + "\\" + id_number + ".jpg");
            else
                StudentPictureBox.Image = StudentPictureBox.ErrorImage;
        }

        private void IdNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------------------------
        //                        SEARCHING FROM DATABASE                               |
        //-------------------------------------------------------------------------------

        private void IdNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //string soughtIdNumber = IdTextBox.Text;
            //SqlCommand scmd = cnn.CreateCommand();
            //scmd.CommandType = CommandType.Text;
            //scmd.CommandText = "SELECT id_number, last_name, student FROM "
            //    + databaseName + ".Odin.student where id_number like ('%" 
            //    + IdTextBox.Text + "%')";
            //Debug.WriteLine(scmd.CommandText);
            //scmd.ExecuteNonQuery();



        }

        private void LoadTableMssql(string tableQueryCommandText)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            
            cnn.Open();
            try
            {
                SqlDataAdapter sda 
                    = new SqlDataAdapter(tableQueryCommandText + " order by last_name", cnn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "stock");
                StudentsDataGridView.DataSource = ds.Tables["stock"];
                // get rid of the row header at the table
                StudentsDataGridView.RowHeadersVisible = false;
                // fill up data grid view with data base,
                // leaving no grey margin on the right of last columns
                StudentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void IdNumberTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            String querystrg;
            querystrg = "SELECT id_number, last_name, student FROM "
                + databaseName + ".Odin.student where id_number like ('%"
                + IdTextBox.Text + "%')";
            if (e.KeyCode == Keys.Enter)
            {
                LoadTableMssql(querystrg);
                int indx;

                indx = StudentsDataGridView.CurrentRow.Index;
                FirstNameTextBox.Text = (String)StudentsDataGridView[1, indx].Value;
                LastNameTextBox.Text = (String)StudentsDataGridView[2, indx].Value;
                loadPhoto((String)StudentsDataGridView[0, indx].Value);
                
            }
            cnn.Close();
        }
    }
}
