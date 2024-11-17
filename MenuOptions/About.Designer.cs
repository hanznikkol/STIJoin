namespace STI_Join.MenuOptions
{
    partial class About
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
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(418, 226);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nunito Sans", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(178, 42);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 7;
            label6.Text = "STI Join";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nunito Sans SemiBold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 42);
            label7.Name = "label7";
            label7.Size = new Size(144, 28);
            label7.TabIndex = 6;
            label7.Text = "System Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nunito Sans", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(188, 87);
            label8.Name = "label8";
            label8.Size = new Size(58, 28);
            label8.TabIndex = 9;
            label8.Text = "1.0.0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nunito Sans SemiBold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(28, 87);
            label9.Name = "label9";
            label9.Size = new Size(159, 28);
            label9.TabIndex = 8;
            label9.Text = "System Version:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nunito Sans", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(173, 179);
            label2.Name = "label2";
            label2.Size = new Size(193, 28);
            label2.TabIndex = 11;
            label2.Text = "December 31, 2023";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nunito Sans SemiBold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 179);
            label3.Name = "label3";
            label3.Size = new Size(139, 28);
            label3.TabIndex = 10;
            label3.Text = "Date Created:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nunito Sans", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(227, 132);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 13;
            label4.Text = "Group 4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nunito Sans SemiBold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 132);
            label5.Name = "label5";
            label5.Size = new Size(193, 28);
            label5.TabIndex = 12;
            label5.Text = "Development Team:";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Location = new Point(40, 30);
            Name = "About";
            Size = new Size(900, 693);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
