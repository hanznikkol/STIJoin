using STI_Join.MenuOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static STI_Join.AccountHolder;

namespace STI_Join
{
    public partial class MainFrm : Form
    {
        private Button activeButton;
        private Home homeUserControl;

        public MainFrm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            SetRoundedForm();

            SetHandCursorForButtons(this);
            SetTextBoxForeColor(this, Color.FromArgb(25, 26, 31));

            //Navigation
            LoadUserControl(new Home());
            SetActiveButton(btnHome);

            homeUserControl = new Home();
            homeUserControl.ViewStudentClick += HomeUserControl_ViewStudentsClick;
            Controls.Add(homeUserControl);

        }



        //Frontend
        //Set Hand Cursor
        private void SetHandCursorForButtons(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                // Check if the control is a button
                if (ctrl is System.Windows.Forms.Button button)
                {
                    // Set hand cursor for the button
                    button.Cursor = Cursors.Hand;
                }

                // Recursively check child controls
                SetHandCursorForButtons(ctrl);
            }
        }

        //All textbox ForeColor
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

        //Form Rounded
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

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }



        //Navigation

        //Active
        private void SetActiveButton(Button button)
        {
            button.BackColor = Color.FromArgb(249, 207, 88); // #F9CF58
            button.ForeColor = Color.FromArgb(25, 26, 31);  // #191A1F
            button.Font = new Font("Nunito Sans", 11, FontStyle.Bold);
            activeButton = button;
        }

        //Inactive
        private void SetInactiveButton(Button button)
        {
            button.BackColor = Color.FromArgb(0, 48, 110);  // #00306E
            button.ForeColor = Color.White;
            button.Font = new Font("Nunito Sans SemiBold", 11, FontStyle.Bold);
        }

        //Iterate
        private UserControl GetUserControlForButton(Button button)
        {
            switch (button)
            {
                case var _ when button == btnHome:
                    return new Home();
                case var _ when button == btnAddStudent:
                    return new AddStudent();
                case var _ when button == btnStudentList:
                    return new StudentList();
                case var _ when button == btnAbout:
                    return new About();
                default:
                    return null;
            }

        }

        //LoadUserControl
        public void LoadUserControl(UserControl userControl)
        {
            contentPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(userControl);
        }

        //Button Initialize
        private void HandleButtonClick(Button clickedButton)
        {
            if (activeButton != null)
            {
                SetInactiveButton(activeButton);
            }
            SetActiveButton(clickedButton);

            LoadUserControl(GetUserControlForButton(clickedButton));
        }


        private void btnAbout_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "About";
            UserControlHelper.HandleButtonClick(btnAbout, activeButton, SetActiveButton, SetInactiveButton, LoadUserControl, "btnAbout");
            minimizeBtn.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserControlHelper.HandleButtonClick(btnHome, activeButton, SetActiveButton, SetInactiveButton, LoadUserControl, "btnHome");
            lblHeader.Text = "Home";
            minimizeBtn.Visible = true;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            UserControlHelper.HandleButtonClick(btnAddStudent, activeButton, SetActiveButton, SetInactiveButton, LoadUserControl, "btnAddStudent");
            lblHeader.Text = "Student Application";
            minimizeBtn.Visible = false;

            if (AddStudent.hasUnsavedChanges)
            {

            }
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            UserControlHelper.HandleButtonClick(btnStudentList, activeButton, SetActiveButton, SetInactiveButton, LoadUserControl, "btnHStudentList");
            lblHeader.Text = "Student List";
            minimizeBtn.Visible = true;
        }

        private void HomeUserControl_ViewStudentsClick(object sender, EventArgs e)
        {
            // Handle the ViewStudentsClick event, similar to btnStudentList_Click
            UserControlHelper.HandleButtonClick(btnStudentList, activeButton, SetActiveButton, SetInactiveButton, LoadUserControl, "btnHStudentList");
            lblHeader.Text = "Student List";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logoutPrompt = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logoutPrompt == DialogResult.Yes)
            {
                ClearLogout();
                LoginFrm loginFrm = new LoginFrm();
                loginFrm.Show();
                this.Close();
            }

        }

        public void ClearLogout()
        {
            AccountHolder.Username = null;
            AccountHolder.AccountID = 0;
        }
    }
}
