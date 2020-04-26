namespace StoredProcedure
{
    partial class StudentInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chbCSharp = new System.Windows.Forms.CheckBox();
            this.chbVB = new System.Windows.Forms.CheckBox();
            this.chbJava = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.StudentInfoTabControl = new System.Windows.Forms.TabControl();
            this.ExtendedDetailsTab = new System.Windows.Forms.TabPage();
            this.cbPayments = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFundType = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressTabPage = new System.Windows.Forms.TabPage();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbLocality = new System.Windows.Forms.ComboBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CommentTab = new System.Windows.Forms.TabPage();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.pbStudentImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.StudentInfoTabControl.SuspendLayout();
            this.ExtendedDetailsTab.SuspendLayout();
            this.AddressTabPage.SuspendLayout();
            this.CommentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(345, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(168, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(345, 67);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(168, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(525, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(525, 53);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interests";
            // 
            // chbCSharp
            // 
            this.chbCSharp.AutoSize = true;
            this.chbCSharp.Location = new System.Drawing.Point(345, 108);
            this.chbCSharp.Name = "chbCSharp";
            this.chbCSharp.Size = new System.Drawing.Size(40, 17);
            this.chbCSharp.TabIndex = 5;
            this.chbCSharp.Text = "C#";
            this.chbCSharp.UseVisualStyleBackColor = true;
            // 
            // chbVB
            // 
            this.chbVB.AutoSize = true;
            this.chbVB.Location = new System.Drawing.Point(391, 108);
            this.chbVB.Name = "chbVB";
            this.chbVB.Size = new System.Drawing.Size(40, 17);
            this.chbVB.TabIndex = 5;
            this.chbVB.Text = "VB";
            this.chbVB.UseVisualStyleBackColor = true;
            // 
            // chbJava
            // 
            this.chbJava.AutoSize = true;
            this.chbJava.Location = new System.Drawing.Point(437, 107);
            this.chbJava.Name = "chbJava";
            this.chbJava.Size = new System.Drawing.Size(49, 17);
            this.chbJava.TabIndex = 5;
            this.chbJava.Text = "Java";
            this.chbJava.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(345, 139);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 6;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(412, 139);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth :";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = " ";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(360, 185);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(153, 20);
            this.dtpDOB.TabIndex = 8;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            this.dtpDOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDOB_KeyDown);
            // 
            // StudentInfoTabControl
            // 
            this.StudentInfoTabControl.Controls.Add(this.ExtendedDetailsTab);
            this.StudentInfoTabControl.Controls.Add(this.AddressTabPage);
            this.StudentInfoTabControl.Controls.Add(this.CommentTab);
            this.StudentInfoTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StudentInfoTabControl.Location = new System.Drawing.Point(0, 237);
            this.StudentInfoTabControl.Name = "StudentInfoTabControl";
            this.StudentInfoTabControl.SelectedIndex = 0;
            this.StudentInfoTabControl.Size = new System.Drawing.Size(615, 182);
            this.StudentInfoTabControl.TabIndex = 14;
            // 
            // ExtendedDetailsTab
            // 
            this.ExtendedDetailsTab.Controls.Add(this.cbPayments);
            this.ExtendedDetailsTab.Controls.Add(this.label7);
            this.ExtendedDetailsTab.Controls.Add(this.cbFundType);
            this.ExtendedDetailsTab.Controls.Add(this.dtpEnd);
            this.ExtendedDetailsTab.Controls.Add(this.label9);
            this.ExtendedDetailsTab.Controls.Add(this.dtpStart);
            this.ExtendedDetailsTab.Controls.Add(this.label8);
            this.ExtendedDetailsTab.Controls.Add(this.label6);
            this.ExtendedDetailsTab.Location = new System.Drawing.Point(4, 22);
            this.ExtendedDetailsTab.Name = "ExtendedDetailsTab";
            this.ExtendedDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExtendedDetailsTab.Size = new System.Drawing.Size(607, 156);
            this.ExtendedDetailsTab.TabIndex = 0;
            this.ExtendedDetailsTab.Text = "Extend Details";
            this.ExtendedDetailsTab.UseVisualStyleBackColor = true;
            // 
            // cbPayments
            // 
            this.cbPayments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayments.FormattingEnabled = true;
            this.cbPayments.Location = new System.Drawing.Point(109, 89);
            this.cbPayments.Name = "cbPayments";
            this.cbPayments.Size = new System.Drawing.Size(177, 21);
            this.cbPayments.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "To";
            // 
            // cbFundType
            // 
            this.cbFundType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFundType.FormattingEnabled = true;
            this.cbFundType.Location = new System.Drawing.Point(109, 57);
            this.cbFundType.Name = "cbFundType";
            this.cbFundType.Size = new System.Drawing.Size(177, 21);
            this.cbFundType.TabIndex = 16;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = " ";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(213, 24);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShowUpDown = true;
            this.dtpEnd.Size = new System.Drawing.Size(75, 20);
            this.dtpEnd.TabIndex = 10;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.Time_ValueChanged);
            this.dtpEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpStart_KeyDown);
            this.dtpEnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpStart_MouseDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Fees Payment";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = " ";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(109, 24);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(71, 20);
            this.dtpStart.TabIndex = 9;
            this.dtpStart.ValueChanged += new System.EventHandler(this.Time_ValueChanged);
            this.dtpStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpStart_KeyDown);
            this.dtpStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpStart_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fund Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Course Timings";
            // 
            // AddressTabPage
            // 
            this.AddressTabPage.Controls.Add(this.cbCity);
            this.AddressTabPage.Controls.Add(this.cbLocality);
            this.AddressTabPage.Controls.Add(this.txtPostCode);
            this.AddressTabPage.Controls.Add(this.tbAddress);
            this.AddressTabPage.Controls.Add(this.label13);
            this.AddressTabPage.Controls.Add(this.label12);
            this.AddressTabPage.Controls.Add(this.label11);
            this.AddressTabPage.Controls.Add(this.label10);
            this.AddressTabPage.Location = new System.Drawing.Point(4, 22);
            this.AddressTabPage.Name = "AddressTabPage";
            this.AddressTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddressTabPage.Size = new System.Drawing.Size(493, 156);
            this.AddressTabPage.TabIndex = 2;
            this.AddressTabPage.Text = "Address";
            this.AddressTabPage.UseVisualStyleBackColor = true;
            // 
            // cbCity
            // 
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(78, 82);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(173, 21);
            this.cbCity.TabIndex = 17;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            this.cbCity.SelectedValueChanged += new System.EventHandler(this.cbCity_SelectedValueChanged);
            // 
            // cbLocality
            // 
            this.cbLocality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocality.FormattingEnabled = true;
            this.cbLocality.Location = new System.Drawing.Point(78, 50);
            this.cbLocality.Name = "cbLocality";
            this.cbLocality.Size = new System.Drawing.Size(173, 21);
            this.cbLocality.TabIndex = 18;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(78, 114);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(173, 20);
            this.txtPostCode.TabIndex = 1;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(78, 15);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(173, 20);
            this.tbAddress.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Post Code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "City";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Locality";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Address";
            // 
            // CommentTab
            // 
            this.CommentTab.Controls.Add(this.CommentBox);
            this.CommentTab.Location = new System.Drawing.Point(4, 22);
            this.CommentTab.Name = "CommentTab";
            this.CommentTab.Padding = new System.Windows.Forms.Padding(3);
            this.CommentTab.Size = new System.Drawing.Size(493, 156);
            this.CommentTab.TabIndex = 1;
            this.CommentTab.Text = "Comments";
            this.CommentTab.UseVisualStyleBackColor = true;
            // 
            // CommentBox
            // 
            this.CommentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommentBox.Location = new System.Drawing.Point(3, 3);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommentBox.Size = new System.Drawing.Size(487, 150);
            this.CommentBox.TabIndex = 14;
            // 
            // pbStudentImage
            // 
            this.pbStudentImage.Image = ((System.Drawing.Image)(resources.GetObject("pbStudentImage.Image")));
            this.pbStudentImage.Location = new System.Drawing.Point(11, 16);
            this.pbStudentImage.Name = "pbStudentImage";
            this.pbStudentImage.Size = new System.Drawing.Size(139, 189);
            this.pbStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudentImage.TabIndex = 15;
            this.pbStudentImage.TabStop = false;
            this.pbStudentImage.Click += new System.EventHandler(this.pbStudentImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 419);
            this.Controls.Add(this.pbStudentImage);
            this.Controls.Add(this.StudentInfoTabControl);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.chbJava);
            this.Controls.Add(this.chbVB);
            this.Controls.Add(this.chbCSharp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info Screen";
            this.Load += new System.EventHandler(this.StudentInfoForm_Load);
            this.StudentInfoTabControl.ResumeLayout(false);
            this.ExtendedDetailsTab.ResumeLayout(false);
            this.ExtendedDetailsTab.PerformLayout();
            this.AddressTabPage.ResumeLayout(false);
            this.AddressTabPage.PerformLayout();
            this.CommentTab.ResumeLayout(false);
            this.CommentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbCSharp;
        private System.Windows.Forms.CheckBox chbVB;
        private System.Windows.Forms.CheckBox chbJava;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TabControl StudentInfoTabControl;
        private System.Windows.Forms.TabPage ExtendedDetailsTab;
        private System.Windows.Forms.ComboBox cbPayments;
        private System.Windows.Forms.ComboBox cbFundType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage CommentTab;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage AddressTabPage;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbLocality;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbStudentImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}