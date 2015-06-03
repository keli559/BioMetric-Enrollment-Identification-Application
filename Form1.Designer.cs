namespace WebKeySingleScan
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEnrolled = new System.Windows.Forms.Label();
            this.webkey = new AxWebKeyClientLib.AxWebKeyAppCtrl();
            this.StatusStripResults = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusstatuslblResults = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AliasButton = new System.Windows.Forms.Button();
            this.IdentificationButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EnrollmentButton = new System.Windows.Forms.Button();
            this.StudentPictureBox = new System.Windows.Forms.PictureBox();
            this.IdNumberToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webkey)).BeginInit();
            this.StatusStripResults.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsDataGridView
            // 
            this.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGridView.Location = new System.Drawing.Point(31, 324);
            this.StudentsDataGridView.Name = "StudentsDataGridView";
            this.StudentsDataGridView.Size = new System.Drawing.Size(503, 188);
            this.StudentsDataGridView.TabIndex = 0;
            this.StudentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDataGridView_CellContentClick);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(172, 142);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(157, 26);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(172, 174);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(157, 26);
            this.FirstNameTextBox.TabIndex = 3;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(172, 206);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(157, 26);
            this.IdTextBox.TabIndex = 4;
            this.IdNumberToolTip.SetToolTip(this.IdTextBox, "Enter text to search");
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdNumberTextBox_TextChanged);
            this.IdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdNumberTextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Number";
            // 
            // lblEnrolled
            // 
            this.lblEnrolled.AutoSize = true;
            this.lblEnrolled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrolled.ForeColor = System.Drawing.Color.Green;
            this.lblEnrolled.Location = new System.Drawing.Point(168, 235);
            this.lblEnrolled.Name = "lblEnrolled";
            this.lblEnrolled.Size = new System.Drawing.Size(104, 20);
            this.lblEnrolled.TabIndex = 9;
            this.lblEnrolled.Text = "ENROLLED";
            // 
            // webkey
            // 
            this.webkey.Enabled = true;
            this.webkey.Location = new System.Drawing.Point(72, 518);
            this.webkey.Name = "webkey";
            this.webkey.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("webkey.OcxState")));
            this.webkey.Size = new System.Drawing.Size(346, 150);
            this.webkey.TabIndex = 10;
            this.webkey.Notify += new AxWebKeyClientLib._IWebKeyAppCtrlEvents_NotifyEventHandler(this.webkey_Notify);
            // 
            // StatusStripResults
            // 
            this.StatusStripResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.statusstatuslblResults});
            this.StatusStripResults.Location = new System.Drawing.Point(0, 668);
            this.StatusStripResults.Name = "StatusStripResults";
            this.StatusStripResults.Size = new System.Drawing.Size(564, 22);
            this.StatusStripResults.TabIndex = 12;
            this.StatusStripResults.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // statusstatuslblResults
            // 
            this.statusstatuslblResults.Name = "statusstatuslblResults";
            this.statusstatuslblResults.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // AliasButton
            // 
            this.AliasButton.Image = global::WebKeySingleScan.Properties.Resources.AliasSearch;
            this.AliasButton.Location = new System.Drawing.Point(268, 263);
            this.AliasButton.Name = "AliasButton";
            this.AliasButton.Size = new System.Drawing.Size(101, 55);
            this.AliasButton.TabIndex = 15;
            this.AliasButton.Text = "Alias Search";
            this.AliasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AliasButton.UseVisualStyleBackColor = true;
            // 
            // IdentificationButton
            // 
            this.IdentificationButton.Image = global::WebKeySingleScan.Properties.Resources.ID;
            this.IdentificationButton.Location = new System.Drawing.Point(161, 263);
            this.IdentificationButton.Name = "IdentificationButton";
            this.IdentificationButton.Size = new System.Drawing.Size(101, 55);
            this.IdentificationButton.TabIndex = 14;
            this.IdentificationButton.Text = "Identification";
            this.IdentificationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.IdentificationButton.UseVisualStyleBackColor = true;
            this.IdentificationButton.Click += new System.EventHandler(this.IdentificationButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WebKeySingleScan.Properties.Resources.topLogo;
            this.pictureBox1.Location = new System.Drawing.Point(74, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 85);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // EnrollmentButton
            // 
            this.EnrollmentButton.Image = global::WebKeySingleScan.Properties.Resources.Enroll;
            this.EnrollmentButton.Location = new System.Drawing.Point(54, 263);
            this.EnrollmentButton.Name = "EnrollmentButton";
            this.EnrollmentButton.Size = new System.Drawing.Size(101, 55);
            this.EnrollmentButton.TabIndex = 8;
            this.EnrollmentButton.Text = "Enroll Fingerprint";
            this.EnrollmentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EnrollmentButton.UseVisualStyleBackColor = true;
            this.EnrollmentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentPictureBox
            // 
            this.StudentPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StudentPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StudentPictureBox.ErrorImage = global::WebKeySingleScan.Properties.Resources.Not_Available;
            this.StudentPictureBox.Location = new System.Drawing.Point(375, 118);
            this.StudentPictureBox.Name = "StudentPictureBox";
            this.StudentPictureBox.Size = new System.Drawing.Size(170, 200);
            this.StudentPictureBox.TabIndex = 1;
            this.StudentPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 690);
            this.Controls.Add(this.AliasButton);
            this.Controls.Add(this.IdentificationButton);
            this.Controls.Add(this.StatusStripResults);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webkey);
            this.Controls.Add(this.lblEnrolled);
            this.Controls.Add(this.EnrollmentButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.StudentPictureBox);
            this.Controls.Add(this.StudentsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Single Fingerprint Enrollment - Odin Inc";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webkey)).EndInit();
            this.StatusStripResults.ResumeLayout(false);
            this.StatusStripResults.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsDataGridView;
        private System.Windows.Forms.PictureBox StudentPictureBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EnrollmentButton;
        private System.Windows.Forms.Label lblEnrolled;
        private AxWebKeyClientLib.AxWebKeyAppCtrl webkey;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip StatusStripResults;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        //private System.Windows.Forms.ToolStripStatusLabel statusstatuslblResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statusstatuslblResults;
        private System.Windows.Forms.Button IdentificationButton;
        private System.Windows.Forms.Button AliasButton;
        private System.Windows.Forms.ToolTip IdNumberToolTip;
    }
}

