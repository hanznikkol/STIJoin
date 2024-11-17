using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static STI_Join.DatabaseHelper;

namespace STI_Join
{
    public partial class LoginFrm : Form
    {

        public LoginFrm()
        {
            Components components = new Components();
            InitializeComponent();

            //Frontend
            this.AutoScaleMode = AutoScaleMode.Dpi;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            SetRoundedForm();

            components.SetHandCursorForButtons(this);

            passwordTxt.PasswordChar = (passwordTxt.PasswordChar == '\0') ? '*' : '\0';
            SetTextBoxForeColor(this, Color.FromArgb(25, 26, 31));

            //Backend

        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult exitPrompt = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitPrompt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string enterUsername = usernameTxt.Text;
            string enterPassword = passwordTxt.Text;

            if (ValidateLoginCredentials(enterUsername, enterPassword))
            {
                MessageBox.Show("Login Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainFrm mainFrm = new MainFrm();
                mainFrm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTxt.Clear();
            }
        }

        //Backend
        private bool ValidateLoginCredentials(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM AdminLogin WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            AccountHolder.AccountID = sdr.GetInt32(sdr.GetOrdinal("AdminID"));
                            AccountHolder.Username = sdr.GetString(sdr.GetOrdinal("Username"));

                            return true;
                        }

                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        private void SetTextBoxForeColor(Control control, Color color)
        {
            foreach (Control ctrl in control.Controls)
            {
                // Check if the control is a TextBox
                if (ctrl is System.Windows.Forms.TextBox textBox)
                {
                    // Set ForeColor for the TextBox
                    textBox.ForeColor = color;
                }

                // Recursively check child controls
                SetTextBoxForeColor(ctrl, color);
            }
        }

        private void SetRoundedForm()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 15, 15, 180, 90); // Top-left corner
            path.AddArc(Width - 15, 0, 15, 15, 270, 90); // Top-right corner
            path.AddArc(Width - 15, Height - 15, 15, 15, 0, 90); // Bottom-right corner
            path.AddArc(0, Height - 15, 15, 15, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Set the form's region to the rounded rectangle path
            Region = new Region(path);
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            passwordTxt.PasswordChar = (passwordTxt.PasswordChar == '\0') ? '*' : '\0';

            btnShowHide.Text = (passwordTxt.PasswordChar == '\0') ? "Hide" : "Show";
        }


    }
}
