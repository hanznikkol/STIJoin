namespace STI_Join
{
    partial class LoginFrm
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
            label1 = new Label();
            label2 = new Label();
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            loginBtn = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            exitBtn = new Button();
            minimizeBtn = new Button();
            panel2 = new Panel();
            btnShowHide = new Button();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(89, 93, 105);
            label1.Location = new Point(82, 263);
            label1.Name = "label1";
            label1.Size = new Size(120, 31);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nunito Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(89, 93, 105);
            label2.Location = new Point(82, 377);
            label2.Name = "label2";
            label2.Size = new Size(119, 31);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // usernameTxt
            // 
            usernameTxt.BackColor = Color.FromArgb(245, 245, 255);
            usernameTxt.Font = new Font("Nunito Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTxt.Location = new Point(36, 298);
            usernameTxt.Margin = new Padding(3, 4, 3, 4);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(593, 39);
            usernameTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.FromArgb(245, 245, 255);
            passwordTxt.Font = new Font("Nunito Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxt.Location = new Point(36, 412);
            passwordTxt.Margin = new Padding(3, 4, 3, 4);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(593, 39);
            passwordTxt.TabIndex = 3;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(249, 207, 88);
            loginBtn.Font = new Font("Nunito Sans", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.Location = new Point(36, 527);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(593, 61);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1320, 58);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(exitBtn);
            panel3.Controls.Add(minimizeBtn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1216, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(104, 58);
            panel3.TabIndex = 0;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(182, 35, 53);
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Nunito Sans", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.ForeColor = Color.White;
            exitBtn.Image = Properties.Resources.Close;
            exitBtn.Location = new Point(53, 7);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(42, 40);
            exitBtn.TabIndex = 1;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.BackColor = Color.FromArgb(28, 84, 197);
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Font = new Font("Nunito Sans Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.Location = new Point(7, 7);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(42, 40);
            minimizeBtn.TabIndex = 0;
            minimizeBtn.Text = "_";
            minimizeBtn.UseVisualStyleBackColor = false;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnShowHide);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(loginBtn);
            panel2.Controls.Add(passwordTxt);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(usernameTxt);
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 698);
            panel2.TabIndex = 8;
            // 
            // btnShowHide
            // 
            btnShowHide.BackColor = Color.White;
            btnShowHide.FlatAppearance.BorderSize = 0;
            btnShowHide.FlatStyle = FlatStyle.Flat;
            btnShowHide.Font = new Font("Nunito Sans", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            btnShowHide.ForeColor = Color.FromArgb(28, 84, 197);
            btnShowHide.Location = new Point(41, 458);
            btnShowHide.Name = "btnShowHide";
            btnShowHide.Size = new Size(72, 29);
            btnShowHide.TabIndex = 12;
            btnShowHide.Text = "Show";
            btnShowHide.UseVisualStyleBackColor = false;
            btnShowHide.Click += btnShowHide_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.stijoin;
            pictureBox4.Location = new Point(180, 20);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(300, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nunito Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(89, 93, 105);
            label4.Location = new Point(41, 204);
            label4.Name = "label4";
            label4.Size = new Size(439, 23);
            label4.TabIndex = 10;
            label4.Text = "To access your account, please provide your login details.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nunito Sans", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 135);
            label3.Name = "label3";
            label3.Size = new Size(161, 58);
            label3.TabIndex = 9;
            label3.Text = "Sign In";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.passwordPic;
            pictureBox2.Location = new Point(41, 373);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usernamePic;
            pictureBox1.Location = new Point(41, 259);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo1;
            pictureBox3.Location = new Point(719, 98);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(550, 550);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1320, 743);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Nunito Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginFrm";
            Load += LoginFrm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private Button loginBtn;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button exitBtn;
        private Button minimizeBtn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnShowHide;
    }
}