namespace STI_Join
{
    partial class MainFrm
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
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            btnAbout = new Button();
            btnLogout = new Button();
            btnStudentList = new Button();
            btnAddStudent = new Button();
            btnHome = new Button();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            exitBtn = new Button();
            minimizeBtn = new Button();
            panel8 = new Panel();
            lblHeader = new Label();
            contentPanel = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 48, 110);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 743);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 84, 197);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 150);
            button1.Name = "button1";
            button1.Size = new Size(0, 50);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 150);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 48, 110);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(btnAbout);
            panel4.Controls.Add(btnLogout);
            panel4.Controls.Add(btnStudentList);
            panel4.Controls.Add(btnAddStudent);
            panel4.Controls.Add(btnHome);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 743);
            panel4.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(249, 207, 88);
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 610);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 3);
            panel7.TabIndex = 7;
            // 
            // btnAbout
            // 
            btnAbout.Dock = DockStyle.Bottom;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Nunito Sans SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbout.ForeColor = Color.FromArgb(15, 255, 255, 255);
            btnAbout.Image = Properties.Resources.about;
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(0, 613);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(15, 0, 0, 0);
            btnAbout.Size = new Size(270, 65);
            btnAbout.TabIndex = 6;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Nunito Sans Black", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.FromArgb(15, 255, 255, 255);
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 678);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(270, 65);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStudentList
            // 
            btnStudentList.Dock = DockStyle.Top;
            btnStudentList.FlatAppearance.BorderSize = 0;
            btnStudentList.FlatStyle = FlatStyle.Flat;
            btnStudentList.Font = new Font("Nunito Sans SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentList.ForeColor = Color.FromArgb(15, 255, 255, 255);
            btnStudentList.Image = Properties.Resources.managestudent;
            btnStudentList.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentList.Location = new Point(0, 280);
            btnStudentList.Name = "btnStudentList";
            btnStudentList.Padding = new Padding(15, 0, 0, 0);
            btnStudentList.Size = new Size(270, 65);
            btnStudentList.TabIndex = 3;
            btnStudentList.Text = "Student List";
            btnStudentList.UseVisualStyleBackColor = true;
            btnStudentList.Click += btnStudentList_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Dock = DockStyle.Top;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Nunito Sans SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddStudent.ForeColor = Color.FromArgb(15, 255, 255, 255);
            btnAddStudent.Image = Properties.Resources.addstudent;
            btnAddStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddStudent.Location = new Point(0, 215);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Padding = new Padding(15, 0, 0, 0);
            btnAddStudent.Size = new Size(270, 65);
            btnAddStudent.TabIndex = 2;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(249, 207, 88);
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Nunito Sans", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Image = Properties.Resources.home;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 150);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(15, 0, 0, 0);
            btnHome.Size = new Size(270, 65);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 150);
            panel6.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.stijoin1;
            pictureBox1.Location = new Point(45, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(exitBtn);
            panel5.Controls.Add(minimizeBtn);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(945, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(105, 50);
            panel5.TabIndex = 0;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(182, 35, 53);
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Nunito Sans", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.ForeColor = Color.White;
            exitBtn.Image = Properties.Resources.Close;
            exitBtn.Location = new Point(54, 7);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(42, 40);
            exitBtn.TabIndex = 1;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.BackColor = Color.FromArgb(28, 84, 197);
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Font = new Font("Nunito Sans Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.Location = new Point(8, 7);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(42, 40);
            minimizeBtn.TabIndex = 0;
            minimizeBtn.Text = "_";
            minimizeBtn.UseVisualStyleBackColor = false;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(lblHeader);
            panel8.Controls.Add(panel5);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(270, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1050, 50);
            panel8.TabIndex = 9;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Nunito Sans Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.FromArgb(28, 84, 197);
            lblHeader.Location = new Point(35, 19);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(79, 31);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Home";
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(270, 50);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1050, 693);
            contentPanel.TabIndex = 10;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1320, 743);
            Controls.Add(contentPanel);
            Controls.Add(panel8);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Font = new Font("Nunito Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "MainFrm";
            Text = "MainFrm";
            Load += MainFrm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Button exitBtn;
        private Button minimizeBtn;
        private Button btnAddStudent;
        private Button btnHome;
        private Button btnLogout;
        private Button btnStudentList;
        private Button btnAbout;
        private Panel panel7;
        private Panel panel8;
        private Panel contentPanel;
        private Label lblHeader;
    }
}