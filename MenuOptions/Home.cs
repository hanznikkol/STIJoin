using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static STI_Join.AccountHolder;
using static STI_Join.DatabaseHelper;

namespace STI_Join.MenuOptions
{
    public partial class Home : UserControl
    {
        public event EventHandler ViewStudentClick;
        public Home()
        {
            InitializeComponent();
            SetHandCursorForButtons(this);
            lblUserName.Text = AccountHolder.Username;
            int studentCounts = GetStudentCount();
            lblStudentRegistered.Text = studentCounts.ToString();
        }

        private int GetStudentCount()
        {
            int studentCount = 0;
            try
            {
                using (SqlConnection sqlConnection = new(DatabaseHelper.connectionString))
                {
                    sqlConnection.Open();
                    string getCountQuery = "SELECT COUNT(*) FROM StudentTBL";
                    using (SqlCommand command = new(getCountQuery, sqlConnection))
                    {
                        studentCount = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"NULL: {ex.Message}");
            }
            return studentCount;
        }


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

        private void Home_Load_1(object sender, EventArgs e)
        {
            timeTicking.Start();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timeTicking_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timeTicking.Start();
        }

        private void btnViewStudentsNav_Click(object sender, EventArgs e)
        {
            ViewStudentClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
