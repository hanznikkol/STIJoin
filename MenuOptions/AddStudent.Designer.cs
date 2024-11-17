namespace STI_Join.MenuOptions
{
    partial class AddStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picStudent = new PictureBox();
            btnUpload = new Button();
            label2 = new Label();
            label3 = new Label();
            txtFirstName = new TextBox();
            txtMName = new TextBox();
            txtLastName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtContactNo = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            btnAddStudent = new Button();
            txtPFullName = new TextBox();
            label8 = new Label();
            txtAge = new TextBox();
            label9 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            txtPEmail = new TextBox();
            label11 = new Label();
            txtPContactNo = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            cbCourse = new ComboBox();
            cbAcadTerm = new ComboBox();
            cbStudType = new ComboBox();
            label15 = new Label();
            txtAddress = new TextBox();
            label16 = new Label();
            cbAcadLevel = new ComboBox();
            label17 = new Label();
            txtExistScholar = new TextBox();
            label18 = new Label();
            panel2 = new Panel();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            cbGender = new ComboBox();
            label19 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            txtStudentNumber = new TextBox();
            label29 = new Label();
            dtRegDate = new DateTimePicker();
            label1 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            label41 = new Label();
            label42 = new Label();
            label43 = new Label();
            label44 = new Label();
            label45 = new Label();
            label46 = new Label();
            label47 = new Label();
            label48 = new Label();
            cbPaymentMethod = new ComboBox();
            label49 = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            SuspendLayout();
            // 
            // picStudent
            // 
            picStudent.BackColor = Color.White;
            picStudent.BorderStyle = BorderStyle.FixedSingle;
            picStudent.Image = Properties.Resources.avatarPic;
            picStudent.Location = new Point(39, 66);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(200, 200);
            picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudent.TabIndex = 0;
            picStudent.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.ForeColor = Color.FromArgb(28, 84, 197);
            btnUpload.Location = new Point(78, 292);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(123, 30);
            btnUpload.TabIndex = 2;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nunito Sans", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(78, 269);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 3;
            label2.Text = "Select a PNG file.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(89, 93, 105);
            label3.Location = new Point(277, 66);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(245, 245, 255);
            txtFirstName.Font = new Font("Nunito Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(277, 92);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Given Name";
            txtFirstName.Size = new Size(250, 32);
            txtFirstName.TabIndex = 5;
            txtFirstName.TextChanged += textBox_TextChanged;
            // 
            // txtMName
            // 
            txtMName.BackColor = Color.FromArgb(245, 245, 255);
            txtMName.Font = new Font("Nunito Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            txtMName.Location = new Point(553, 92);
            txtMName.Name = "txtMName";
            txtMName.PlaceholderText = "Middle Initial";
            txtMName.Size = new Size(180, 32);
            txtMName.TabIndex = 6;
            txtMName.TextChanged += textBox_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(245, 245, 255);
            txtLastName.Font = new Font("Nunito Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(758, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Surname";
            txtLastName.Size = new Size(250, 32);
            txtLastName.TabIndex = 7;
            txtLastName.TextChanged += textBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(89, 93, 105);
            label4.Location = new Point(553, 66);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 8;
            label4.Text = "Middle Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(89, 93, 105);
            label5.Location = new Point(758, 66);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 9;
            label5.Text = "Last Name:";
            // 
            // txtContactNo
            // 
            txtContactNo.BackColor = Color.FromArgb(245, 245, 255);
            txtContactNo.Font = new Font("Nunito Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactNo.Location = new Point(277, 172);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.PlaceholderText = "09XXXXXXXXX";
            txtContactNo.Size = new Size(250, 32);
            txtContactNo.TabIndex = 11;
            txtContactNo.TextChanged += textBox_TextChanged;
            txtContactNo.KeyPress += txtContactNo_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(89, 93, 105);
            label6.Location = new Point(277, 146);
            label6.Name = "label6";
            label6.Size = new Size(103, 23);
            label6.TabIndex = 10;
            label6.Text = "Contact No:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(245, 245, 255);
            txtEmail.Font = new Font("Nunito Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(553, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "student@gmail.com";
            txtEmail.Size = new Size(320, 32);
            txtEmail.TabIndex = 13;
            txtEmail.TextChanged += textBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(89, 93, 105);
            label7.Location = new Point(553, 146);
            label7.Name = "label7";
            label7.Size = new Size(126, 23);
            label7.TabIndex = 12;
            label7.Text = "Email Address:";
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(249, 207, 88);
            btnAddStudent.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddStudent.ForeColor = Color.FromArgb(25, 26, 31);
            btnAddStudent.Location = new Point(859, 621);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(151, 56);
            btnAddStudent.TabIndex = 14;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // txtPFullName
            // 
            txtPFullName.BackColor = Color.FromArgb(245, 245, 255);
            txtPFullName.Font = new Font("Nunito Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            txtPFullName.Location = new Point(48, 565);
            txtPFullName.Name = "txtPFullName";
            txtPFullName.PlaceholderText = "Guardian's Name";
            txtPFullName.Size = new Size(350, 32);
            txtPFullName.TabIndex = 16;
            txtPFullName.TextChanged += textBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(89, 93, 105);
            label8.Location = new Point(48, 539);
            label8.Name = "label8";
            label8.Size = new Size(93, 23);
            label8.TabIndex = 15;
            label8.Text = "Full Name:";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(245, 245, 255);
            txtAge.Font = new Font("Nunito Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(897, 172);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(111, 32);
            txtAge.TabIndex = 18;
            txtAge.TextChanged += textBox_TextChanged;
            txtAge.KeyPress += txtAge_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(89, 93, 105);
            label9.Location = new Point(897, 146);
            label9.Name = "label9";
            label9.Size = new Size(46, 23);
            label9.TabIndex = 17;
            label9.Text = "Age:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nunito Sans Black", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 48, 110);
            label10.Location = new Point(48, 504);
            label10.Name = "label10";
            label10.Size = new Size(169, 25);
            label10.TabIndex = 19;
            label10.Text = "Parent's/Guardian";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 207, 88);
            panel1.Location = new Point(218, 519);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 1);
            panel1.TabIndex = 20;
            // 
            // txtPEmail
            // 
            txtPEmail.BackColor = Color.FromArgb(245, 245, 255);
            txtPEmail.Font = new Font("Nunito Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            txtPEmail.Location = new Point(690, 565);
            txtPEmail.Name = "txtPEmail";
            txtPEmail.PlaceholderText = "parent@gmail.com";
            txtPEmail.Size = new Size(320, 32);
            txtPEmail.TabIndex = 22;
            txtPEmail.TextChanged += textBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(89, 93, 105);
            label11.Location = new Point(690, 539);
            label11.Name = "label11";
            label11.Size = new Size(126, 23);
            label11.TabIndex = 21;
            label11.Text = "Email Address:";
            // 
            // txtPContactNo
            // 
            txtPContactNo.BackColor = Color.FromArgb(245, 245, 255);
            txtPContactNo.Font = new Font("Nunito Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            txtPContactNo.Location = new Point(417, 565);
            txtPContactNo.Name = "txtPContactNo";
            txtPContactNo.PlaceholderText = "09XXXXXXXXX";
            txtPContactNo.Size = new Size(250, 32);
            txtPContactNo.TabIndex = 24;
            txtPContactNo.TextChanged += textBox_TextChanged;
            txtPContactNo.KeyPress += txtPContactNo_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(89, 93, 105);
            label12.Location = new Point(417, 539);
            label12.Name = "label12";
            label12.Size = new Size(103, 23);
            label12.TabIndex = 23;
            label12.Text = "Contact No:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(89, 93, 105);
            label13.Location = new Point(714, 428);
            label13.Name = "label13";
            label13.Size = new Size(135, 23);
            label13.TabIndex = 25;
            label13.Text = "Academic Term:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(89, 93, 105);
            label14.Location = new Point(322, 352);
            label14.Name = "label14";
            label14.Size = new Size(144, 23);
            label14.TabIndex = 27;
            label14.Text = "Course/Program:";
            // 
            // cbCourse
            // 
            cbCourse.BackColor = Color.FromArgb(245, 245, 255);
            cbCourse.Font = new Font("Nunito Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(322, 383);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(456, 31);
            cbCourse.TabIndex = 29;
            cbCourse.SelectedValueChanged += combobox_SelectedValueChanged;
            // 
            // cbAcadTerm
            // 
            cbAcadTerm.BackColor = Color.FromArgb(245, 245, 255);
            cbAcadTerm.Font = new Font("Nunito Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbAcadTerm.FormattingEnabled = true;
            cbAcadTerm.Location = new Point(714, 460);
            cbAcadTerm.Name = "cbAcadTerm";
            cbAcadTerm.Size = new Size(294, 31);
            cbAcadTerm.TabIndex = 30;
            cbAcadTerm.SelectedValueChanged += combobox_SelectedValueChanged;
            // 
            // cbStudType
            // 
            cbStudType.BackColor = Color.FromArgb(245, 245, 255);
            cbStudType.Font = new Font("Nunito Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbStudType.FormattingEnabled = true;
            cbStudType.Location = new Point(48, 383);
            cbStudType.Name = "cbStudType";
            cbStudType.Size = new Size(248, 31);
            cbStudType.TabIndex = 32;
            cbStudType.SelectedValueChanged += combobox_SelectedValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(89, 93, 105);
            label15.Location = new Point(48, 355);
            label15.Name = "label15";
            label15.Size = new Size(123, 23);
            label15.TabIndex = 31;
            label15.Text = "Student Type: ";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(245, 245, 255);
            txtAddress.Font = new Font("Nunito Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(430, 257);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(578, 32);
            txtAddress.TabIndex = 34;
            txtAddress.TextChanged += textBox_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(89, 93, 105);
            label16.Location = new Point(432, 231);
            label16.Name = "label16";
            label16.Size = new Size(79, 23);
            label16.TabIndex = 33;
            label16.Text = "Address:";
            // 
            // cbAcadLevel
            // 
            cbAcadLevel.BackColor = Color.FromArgb(245, 245, 255);
            cbAcadLevel.Font = new Font("Nunito Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbAcadLevel.FormattingEnabled = true;
            cbAcadLevel.Location = new Point(806, 383);
            cbAcadLevel.Name = "cbAcadLevel";
            cbAcadLevel.Size = new Size(202, 31);
            cbAcadLevel.TabIndex = 36;
            cbAcadLevel.SelectedValueChanged += combobox_SelectedValueChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(89, 93, 105);
            label17.Location = new Point(806, 352);
            label17.Name = "label17";
            label17.Size = new Size(135, 23);
            label17.TabIndex = 35;
            label17.Text = "Academic Level:";
            // 
            // txtExistScholar
            // 
            txtExistScholar.BackColor = Color.FromArgb(245, 245, 255);
            txtExistScholar.Font = new Font("Nunito Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            txtExistScholar.Location = new Point(48, 458);
            txtExistScholar.Name = "txtExistScholar";
            txtExistScholar.PlaceholderText = "(e.g. STI Alumni Scholarship)";
            txtExistScholar.Size = new Size(644, 32);
            txtExistScholar.TabIndex = 38;
            txtExistScholar.TextChanged += textBox_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(89, 93, 105);
            label18.Location = new Point(48, 430);
            label18.Name = "label18";
            label18.Size = new Size(167, 23);
            label18.TabIndex = 37;
            label18.Text = "Existing Scholarship";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 207, 88);
            panel2.Location = new Point(443, 321);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 1);
            panel2.TabIndex = 44;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Nunito Sans Black", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(0, 48, 110);
            label20.Location = new Point(279, 306);
            label20.Name = "label20";
            label20.Size = new Size(159, 25);
            label20.TabIndex = 43;
            label20.Text = "Academic Profile";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Nunito Sans Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(25, 26, 31);
            label21.Location = new Point(890, 18);
            label21.Name = "label21";
            label21.Size = new Size(118, 20);
            label21.TabIndex = 47;
            label21.Text = "Required Fields";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(89, 93, 105);
            label22.Location = new Point(275, 231);
            label22.Name = "label22";
            label22.Size = new Size(71, 23);
            label22.TabIndex = 48;
            label22.Text = "Gender:";
            // 
            // cbGender
            // 
            cbGender.BackColor = Color.FromArgb(245, 245, 255);
            cbGender.Font = new Font("Nunito Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(277, 257);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(133, 31);
            cbGender.TabIndex = 50;
            cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Nunito Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(0, 48, 110);
            label19.Location = new Point(530, 231);
            label19.Name = "label19";
            label19.Size = new Size(456, 20);
            label19.TabIndex = 51;
            label19.Text = "(House no. / Street / Subdivision / Brgy. City, Postal Code, Province) ";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Nunito Sans", 7.799999F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = Color.FromArgb(0, 48, 110);
            label25.Location = new Point(399, 150);
            label25.Name = "label25";
            label25.Size = new Size(87, 18);
            label25.TabIndex = 54;
            label25.Text = "(11 digit No.) ";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Nunito Sans", 7.799999F, FontStyle.Regular, GraphicsUnit.Point);
            label26.ForeColor = Color.FromArgb(0, 48, 110);
            label26.Location = new Point(539, 544);
            label26.Name = "label26";
            label26.Size = new Size(87, 18);
            label26.TabIndex = 55;
            label26.Text = "(11 digit No.) ";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Nunito Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label27.ForeColor = Color.FromArgb(0, 48, 110);
            label27.Location = new Point(218, 432);
            label27.Name = "label27";
            label27.Size = new Size(0, 20);
            label27.TabIndex = 56;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Nunito Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.FromArgb(89, 93, 105);
            label28.Location = new Point(48, 617);
            label28.Name = "label28";
            label28.Size = new Size(126, 23);
            label28.TabIndex = 57;
            label28.Text = "Register Date: ";
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.BackColor = Color.FromArgb(245, 245, 255);
            txtStudentNumber.Font = new Font("Nunito Sans", 7.799999F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudentNumber.Location = new Point(181, 18);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.PlaceholderText = "02000XXXXXX";
            txtStudentNumber.Size = new Size(250, 25);
            txtStudentNumber.TabIndex = 60;
            txtStudentNumber.KeyPress += txtStudentNumber_KeyPress;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = Color.FromArgb(89, 93, 105);
            label29.Location = new Point(32, 23);
            label29.Name = "label29";
            label29.Size = new Size(130, 20);
            label29.TabIndex = 59;
            label29.Text = "Student Number:";
            // 
            // dtRegDate
            // 
            dtRegDate.CalendarForeColor = Color.FromArgb(25, 26, 31);
            dtRegDate.CalendarMonthBackground = Color.White;
            dtRegDate.CalendarTitleBackColor = Color.FromArgb(28, 84, 197);
            dtRegDate.CalendarTitleForeColor = Color.FromArgb(25, 26, 31);
            dtRegDate.CalendarTrailingForeColor = Color.FromArgb(89, 93, 105);
            dtRegDate.Location = new Point(48, 638);
            dtRegDate.MinDate = new DateTime(2024, 1, 9, 0, 0, 0, 0);
            dtRegDate.Name = "dtRegDate";
            dtRegDate.Size = new Size(294, 28);
            dtRegDate.TabIndex = 61;
            dtRegDate.ValueChanged += regDate_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(182, 35, 53);
            label1.Location = new Point(373, 68);
            label1.Name = "label1";
            label1.Size = new Size(16, 20);
            label1.TabIndex = 62;
            label1.Text = "*";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.FromArgb(182, 35, 53);
            label31.Location = new Point(857, 68);
            label31.Name = "label31";
            label31.Size = new Size(16, 20);
            label31.TabIndex = 64;
            label31.Text = "*";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label32.ForeColor = Color.FromArgb(182, 35, 53);
            label32.Location = new Point(377, 148);
            label32.Name = "label32";
            label32.Size = new Size(16, 20);
            label32.TabIndex = 65;
            label32.Text = "*";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label33.ForeColor = Color.FromArgb(182, 35, 53);
            label33.Location = new Point(676, 150);
            label33.Name = "label33";
            label33.Size = new Size(16, 20);
            label33.TabIndex = 66;
            label33.Text = "*";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label34.ForeColor = Color.FromArgb(182, 35, 53);
            label34.Location = new Point(879, 18);
            label34.Name = "label34";
            label34.Size = new Size(16, 20);
            label34.TabIndex = 67;
            label34.Text = "*";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label35.ForeColor = Color.FromArgb(182, 35, 53);
            label35.Location = new Point(949, 149);
            label35.Name = "label35";
            label35.Size = new Size(16, 20);
            label35.TabIndex = 68;
            label35.Text = "*";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label36.ForeColor = Color.FromArgb(182, 35, 53);
            label36.Location = new Point(343, 234);
            label36.Name = "label36";
            label36.Size = new Size(16, 20);
            label36.TabIndex = 69;
            label36.Text = "*";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label37.ForeColor = Color.FromArgb(182, 35, 53);
            label37.Location = new Point(508, 233);
            label37.Name = "label37";
            label37.Size = new Size(16, 20);
            label37.TabIndex = 70;
            label37.Text = "*";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label38.ForeColor = Color.FromArgb(182, 35, 53);
            label38.Location = new Point(159, 357);
            label38.Name = "label38";
            label38.Size = new Size(16, 20);
            label38.TabIndex = 71;
            label38.Text = "*";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label39.ForeColor = Color.FromArgb(182, 35, 53);
            label39.Location = new Point(159, 23);
            label39.Name = "label39";
            label39.Size = new Size(16, 20);
            label39.TabIndex = 72;
            label39.Text = "*";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label40.ForeColor = Color.FromArgb(182, 35, 53);
            label40.Location = new Point(459, 354);
            label40.Name = "label40";
            label40.Size = new Size(16, 20);
            label40.TabIndex = 73;
            label40.Text = "*";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label41.ForeColor = Color.FromArgb(182, 35, 53);
            label41.Location = new Point(934, 354);
            label41.Name = "label41";
            label41.Size = new Size(16, 20);
            label41.TabIndex = 74;
            label41.Text = "*";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label42.ForeColor = Color.FromArgb(182, 35, 53);
            label42.Location = new Point(842, 431);
            label42.Name = "label42";
            label42.Size = new Size(16, 20);
            label42.TabIndex = 75;
            label42.Text = "*";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label43.ForeColor = Color.FromArgb(182, 35, 53);
            label43.Location = new Point(138, 542);
            label43.Name = "label43";
            label43.Size = new Size(16, 20);
            label43.TabIndex = 76;
            label43.Text = "*";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label44.ForeColor = Color.FromArgb(182, 35, 53);
            label44.Location = new Point(517, 541);
            label44.Name = "label44";
            label44.Size = new Size(16, 20);
            label44.TabIndex = 77;
            label44.Text = "*";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label45.ForeColor = Color.FromArgb(182, 35, 53);
            label45.Location = new Point(813, 543);
            label45.Name = "label45";
            label45.Size = new Size(16, 20);
            label45.TabIndex = 78;
            label45.Text = "*";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Nunito Sans", 7.799999F, FontStyle.Regular, GraphicsUnit.Point);
            label46.ForeColor = Color.FromArgb(0, 48, 110);
            label46.Location = new Point(483, 18);
            label46.Name = "label46";
            label46.Size = new Size(319, 18);
            label46.TabIndex = 79;
            label46.Text = "Note: Please fill out the form before uploading a photo.";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label47.ForeColor = Color.FromArgb(182, 35, 53);
            label47.Location = new Point(168, 615);
            label47.Name = "label47";
            label47.Size = new Size(16, 20);
            label47.TabIndex = 80;
            label47.Text = "*";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label48.ForeColor = Color.FromArgb(182, 35, 53);
            label48.Location = new Point(547, 617);
            label48.Name = "label48";
            label48.Size = new Size(16, 20);
            label48.TabIndex = 83;
            label48.Text = "*";
            // 
            // cbPaymentMethod
            // 
            cbPaymentMethod.BackColor = Color.FromArgb(245, 245, 255);
            cbPaymentMethod.Font = new Font("Nunito Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbPaymentMethod.FormattingEnabled = true;
            cbPaymentMethod.Location = new Point(417, 638);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(261, 28);
            cbPaymentMethod.TabIndex = 82;
            cbPaymentMethod.SelectedValueChanged += combobox_SelectedValueChanged;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Font = new Font("Nunito Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label49.ForeColor = Color.FromArgb(89, 93, 105);
            label49.Location = new Point(417, 617);
            label49.Name = "label49";
            label49.Size = new Size(133, 20);
            label49.TabIndex = 81;
            label49.Text = "Payment Method:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(182, 35, 53);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(78, 292);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 30);
            btnClear.TabIndex = 84;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnClear);
            Controls.Add(label48);
            Controls.Add(cbPaymentMethod);
            Controls.Add(label49);
            Controls.Add(label47);
            Controls.Add(label46);
            Controls.Add(label45);
            Controls.Add(label44);
            Controls.Add(label43);
            Controls.Add(label42);
            Controls.Add(label41);
            Controls.Add(label40);
            Controls.Add(label39);
            Controls.Add(label38);
            Controls.Add(label37);
            Controls.Add(label36);
            Controls.Add(label35);
            Controls.Add(label34);
            Controls.Add(label33);
            Controls.Add(label32);
            Controls.Add(label31);
            Controls.Add(label1);
            Controls.Add(dtRegDate);
            Controls.Add(txtStudentNumber);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label19);
            Controls.Add(cbGender);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(panel2);
            Controls.Add(label20);
            Controls.Add(txtExistScholar);
            Controls.Add(label18);
            Controls.Add(cbAcadLevel);
            Controls.Add(label17);
            Controls.Add(txtAddress);
            Controls.Add(label16);
            Controls.Add(cbStudType);
            Controls.Add(label15);
            Controls.Add(cbAcadTerm);
            Controls.Add(cbCourse);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(txtPContactNo);
            Controls.Add(label12);
            Controls.Add(txtPEmail);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(txtAge);
            Controls.Add(label9);
            Controls.Add(txtPFullName);
            Controls.Add(label8);
            Controls.Add(btnAddStudent);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtContactNo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(txtMName);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnUpload);
            Controls.Add(picStudent);
            Font = new Font("Nunito Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddStudent";
            Size = new Size(1050, 693);
            Load += AddStudent_Load;
            Leave += AddStudent_Leave;
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picStudent;
        private Button btnUpload;
        private Label label2;
        private Label label3;
        private TextBox txtFirstName;
        private TextBox txtMName;
        private TextBox txtLastName;
        private Label label4;
        private Label label5;
        private TextBox txtContactNo;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private Button btnAddStudent;
        private TextBox txtPFullName;
        private Label label8;
        private TextBox txtAge;
        private Label label9;
        private Label label10;
        private Panel panel1;
        private TextBox txtPEmail;
        private Label label11;
        private TextBox txtPContactNo;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox cbCourse;
        private ComboBox cbAcadTerm;
        private ComboBox cbStudType;
        private Label label15;
        private TextBox txtAddress;
        private Label label16;
        private ComboBox cbAcadLevel;
        private Label label17;
        private TextBox txtExistScholar;
        private Label label18;
        private Panel panel2;
        private Label label20;
        private Label label21;
        private Label label22;
        private ComboBox cbGender;
        private Label label19;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private TextBox txtStudentNumber;
        private Label label29;
        private DateTimePicker dtRegDate;
        private Label label1;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private ComboBox cbPaymentMethod;
        private Label label49;
        private Button btnClear;
    }
}
