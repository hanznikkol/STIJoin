using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static STI_Join.DatabaseHelper;

namespace STI_Join.MenuOptions
{
    public partial class StudentList : UserControl
    {
        public StudentList()
        {
            InitializeComponent();
            Components components = new Components();
            components.SetHandCursorForButtons(this);


        }

        //Search
        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchBar.Text;

            SearchingStudents(searchTerm);
        }

        public void SearchingStudents(string searchTerm)
        {
            using (SqlConnection sqlConnection = new(DatabaseHelper.connectionString))
            {
                sqlConnection.Open();
                string searchQuery = "%" + searchTerm.ToLower() + "%";

                string sqlQuery = "SELECT StudentID, StudentNumber, CourseProgram, AcademicLevel, Gender, ProfilePicture, RegisterDate, " +
                          "FirstName + ' ' + MiddleName + ' ' + LastName AS FullName " +
                          "FROM StudentTBL " +
                          "WHERE LOWER(StudentNumber) LIKE @SearchQuery OR " +
                          "LOWER(CourseProgram) LIKE @SearchQuery OR " +
                          "LOWER(AcademicLevel) LIKE @SearchQuery OR " +
                          "LOWER(FirstName) LIKE @SearchQuery OR " +
                          "LOWER(MiddleName) LIKE @SearchQuery OR " +
                          "LOWER(LastName) LIKE @SearchQuery OR " +
                          "LOWER(FirstName + ' ' + MiddleName + ' ' + LastName) LIKE @SearchQuery";
                using (SqlCommand sqlCommand = new(sqlQuery, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchQuery", searchQuery);
                    using (SqlDataAdapter adapter = new(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dtgvStudentList.DataSource = dataTable;
                    }
                }
            }
        }

        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvStudentList.SelectedRows.Count > 0)
            {
                int selectedStudentID = (int)dtgvStudentList.SelectedRows[0].Cells["StudentID"].Value;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (DeleteStudentRecord(selectedStudentID))
                    {
                        dtgvStudentList.Rows.RemoveAt(dtgvStudentList.SelectedRows[0].Index);
                        MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error deleting student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DeleteStudentRecord(int studentID)
        {
            try
            {
                using (SqlConnection sqlConnection = new(DatabaseHelper.connectionString))
                {
                    sqlConnection.Open();
                    string deleteQuery = "DELETE FROM StudentTBL WHERE StudentID = @StudentID";

                    using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@StudentID", studentID);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void PopulateStudentList()
        {
            try
            {
                using (SqlConnection sqlConnection = new(DatabaseHelper.connectionString))
                {
                    sqlConnection.Open();
                    string query = "SELECT " +
                        "StudentID, StudentNumber, CourseProgram , " +
                        "AcademicLevel, Gender, ProfilePicture, RegisterDate, FirstName + ' ' + MiddleName + ' ' + LastName " +
                        "AS FullName FROM StudentTBL";

                    using (SqlCommand sqlCommand = new(query, sqlConnection))
                    {

                        SqlDataAdapter sqlDataAdapter = new(sqlCommand);
                        DataTable dataTable = new();
                        sqlDataAdapter.Fill(dataTable);

                        dtgvStudentList.DataSource = dataTable;
                        dtgvStudentList.Columns["StudentID"].Visible = false;

                        dtgvStudentList.Columns["ProfilePicture"].Width = 50;
                        dtgvStudentList.Columns["StudentNumber"].Width = 120;
                        dtgvStudentList.Columns["CourseProgram"].Width = 240;
                        dtgvStudentList.Columns["Gender"].Width = 100;
                        dtgvStudentList.Columns["AcademicLevel"].Width = 100;

                        dtgvStudentList.Columns["ProfilePicture"].DisplayIndex = 0;
                        dtgvStudentList.Columns["FullName"].DisplayIndex = 1;
                        dtgvStudentList.Columns["StudentNumber"].DisplayIndex = 2;
                        dtgvStudentList.Columns["CourseProgram"].DisplayIndex = 3;
                        dtgvStudentList.Columns["AcademicLevel"].DisplayIndex = 4;
                        dtgvStudentList.Columns["Gender"].DisplayIndex = 5;
                        dtgvStudentList.Columns["RegisterDate"].DisplayIndex = 6;

                        dtgvStudentList.Columns["ProfilePicture"].HeaderText = "";
                        dtgvStudentList.Columns["StudentNumber"].HeaderText = "Student Number";
                        dtgvStudentList.Columns["FullName"].HeaderText = "Full Name";
                        dtgvStudentList.Columns["CourseProgram"].HeaderText = "Course";
                        dtgvStudentList.Columns["AcademicLevel"].HeaderText = "Academic Level";
                        dtgvStudentList.Columns["Gender"].HeaderText = "Gender";
                        dtgvStudentList.Columns["RegisterDate"].HeaderText = "Registration Date";

                        ((DataGridViewImageColumn)dtgvStudentList.Columns["ProfilePicture"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

                        foreach (DataGridViewRow dataRow in dtgvStudentList.Rows)
                        {
                            byte[] imageData = (byte[])dataRow.Cells["ProfilePicture"].Value;
                            if (imageData != null && imageData.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);

                                    dataRow.Cells["ProfilePicture"].Value = image.Clone();
                                }
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            PopulateStudentList();
        }

        private void dtgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgvStudentList.Rows.Count)
            {
                int selectedStudentID = Convert.ToInt32(dtgvStudentList.Rows[e.RowIndex].Cells["StudentID"].Value);

                EditStudentFrm editStudentForm = new EditStudentFrm(selectedStudentID);
                editStudentForm.ShowDialog();
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateStudentList();
            txtSearchBar.Clear();
        }
    }
}
