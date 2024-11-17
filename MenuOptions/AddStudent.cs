using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic;
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
using static STI_Join.DatabaseHelper;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace STI_Join.MenuOptions
{

    public partial class AddStudent : UserControl
    {
        private const int MaxAgeLength = 2;
        private const int MaxLength = 11;
        public static bool hasUnsavedChanges = false;
        private bool isImageUploaded = false;
        private bool isGenderChanged = false;
        public AddStudent()
        {
            InitializeComponent();
            SetHandCursorForButtons(this);

            dtRegDate.MinDate = DateTime.Now;
            btnClear.Visible = false;

            PopulateComboBox();


        }

        //Photo Related Codes
        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PNG Files (*.png)|*.png|All files (*.*)|*.*";
                openFileDialog.Title = "Select a Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image tempImage = new Bitmap(openFileDialog.FileName);

                        if (picStudent.Image != null)
                        {
                            picStudent.Image.Dispose();
                        }

                        picStudent.Image = new Bitmap(tempImage);
                        picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
                        picStudent.Size = new Size(200, 200);

                        tempImage.Dispose();
                        isImageUploaded = true;
                        isGenderChanged = true;
                        btnClear.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGender = cbGender.Text;
            // Check if the gender has changed
            if (isImageUploaded && isGenderChanged)
            {
                isGenderChanged = false;
                return;
            }

            // Handle gender selection
            switch (selectedGender)
            {
                case "Male":
                    picStudent.Image = Properties.Resources.avatarPic;
                    break;
                case "Female":
                    picStudent.Image = Properties.Resources.avatarGirlPic;
                    break;
                case "Rather not say":
                    picStudent.Image = Properties.Resources.avatarPic;
                    break;
                default:
                    picStudent.Image = Properties.Resources.avatarPic;
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImage();

            btnClear.Visible = false;
        }

        private void ClearImage()
        {
            picStudent.Image = Properties.Resources.avatarPic;
            isImageUploaded = false;
            isGenderChanged = false;
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Save the image to the MemoryStream
                    image.Save(ms, ImageFormat.Png);
                    // Return a copy of the MemoryStream's buffer
                    return ms.ToArray();
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(image), "Image cannot be null.");
            }

        }


        //Date
        private void regDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtRegDate.Value < DateTime.Today)
            {
                MessageBox.Show("Please select a date from today onwards.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtRegDate.Value = DateTime.Today;
            }
        }

        //SetButtonCursor
        private void SetHandCursorForButtons(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is System.Windows.Forms.Button button)
                {
                    button.Cursor = Cursors.Hand;
                }
                SetHandCursorForButtons(ctrl);
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }


        //Insert those combobox
        public void PopulateComboBox()
        {
            //Programs
            string[] arrPrograms = {
             "Bachelor of Science in Computer Science (BSCS)",
             "Bachelor of Science in Information Technology (BSIT)",
             "Bachelor of Science in Information Systems (BSIS)",
             "Bachelor of Science in Computer Engineering (BSCpE)",
             "Bachelor of Science in Business Administration (BSBA)",
             "Bachelor of Science in Accounting Information System (BSAIS)",
             "Bachelor of Science in Accountancy (BSA)",
             "Bachelor of Science in Culinary Management (BSCM)",
             "Bachelor of Arts in Communication (BACOMM)",
             "Bachelor of Multimedia Arts (BMMA)",
             "Bachelor of Science in Tourism Management (BSTM)"
            };
            PopulateComboBox(cbCourse, arrPrograms);

            // Academic Level
            string[] arrAcadLevel = { "1st Year", "2nd Year", "3rd Year", "4th Year" };
            PopulateComboBox(cbAcadLevel, arrAcadLevel);

            //Student Type
            string[] arrStudentType = { "Regular", "Irregular" };
            PopulateComboBox(cbStudType, arrStudentType);

            //Academic Term
            string[] arrAcadTerm = { "1st Term", "2nd Term" };
            PopulateComboBox(cbAcadTerm, arrAcadTerm);

            //Gender
            string[] arrGender = { "Male", "Female", "Rather not say" };
            PopulateComboBox(cbGender, arrGender);

            string[] arrPaymentMethod = { "Full Payment", "Installment" };
            PopulateComboBox(cbPaymentMethod, arrPaymentMethod);
        }

        public void PopulateComboBox(ComboBox combobox, string[] items)
        {
            foreach (string item in items)
            {
                combobox.Items.Add(item);
            }
        }



        //ADDING STUDENT
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {

                string studentNo = txtStudentNumber.Text;
                string fName = txtFirstName.Text;
                string mName = txtMName.Text;
                string lName = txtLastName.Text;
                string contactNo = txtContactNo.Text;
                string eMail = txtEmail.Text;
                string existingScholarship = txtExistScholar.Text;
                string pFullName = txtPFullName.Text;
                string pContactNo = txtPContactNo.Text;
                string pEmail = txtPEmail.Text;
                int Age;
                string sGender = cbGender.Text;
                string sAddress = txtAddress.Text;
                string studType = cbStudType.Text;
                string courseProg = cbCourse.Text;
                string acadLevel = cbAcadLevel.Text;
                string acadTerm = cbAcadTerm.Text;
                string paymentMethod = cbPaymentMethod.Text;
                DateTime registerDate = dtRegDate.Value;
                Image profilePic = picStudent.Image;


                if (CheckFieldsFilled(out Age))
                {
                    StudentInfo studentInfo = new StudentInfo
                    {
                        StudentNo = studentNo,
                        FirstName = fName,
                        MiddleName = mName,
                        LastName = lName,
                        ContactNo = contactNo,
                        Email = eMail,
                        Age = Age,
                        Gender = sGender,
                        Address = sAddress,
                        StudentType = studType,
                        CourseProgram = courseProg,
                        AcademicLevel = acadLevel,
                        ExistingScholarship = existingScholarship,
                        AcademicTerm = acadTerm,
                        ParentsFullName = pFullName,
                        ParentsContactNo = pContactNo,
                        ParentsEmail = pEmail,
                        RegisterDate = registerDate,
                        PaymentMethod = paymentMethod,
                        ProfilePicture = ConvertImageToByteArray(profilePic)
                    };

                    bool success = AddingStudent(studentInfo);

                    if (success)
                    {
                        MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAllInputs();
                        ClearImage();
                    }

                    else
                    {
                        MessageBox.Show("Error adding student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool AddingStudent(StudentInfo studentInfo)
        {
            try
            {

                using (SqlConnection connectString = new(DatabaseHelper.connectionString))
                {
                    connectString.Open();
                    string addQuery = @"
                    INSERT INTO StudentTBL(
                    StudentNumber, AdminID, FirstName, MiddleName, LastName, ContactNo, Email, Age, Address,
                    ExistingScholarship, ParentsFullName, ParentsContactNo, ParentsEmail,
                    Gender, StudentType, CourseProgram, AcademicLevel, AcademicTerm,
                    ProfilePicture, PaymentMethod, RegisterDate)
                    VALUES (
                    @StudentNumber, @AdminID, @FirstName, @MiddleName, @LastName, @ContactNo, @Email, @Age, @Address,
                    @ExistingScholarship, @ParentsFullName, @ParentsContactNo, @ParentsEmail,
                    @Gender, @StudentType, @CourseProgram, @AcademicLevel, @AcademicTerm,
                    @ProfilePicture, @PaymentMethod, @RegisterDate)
                    ";

                    using (SqlCommand sqlCommand = new(addQuery, connectString))
                    {
                        sqlCommand.Parameters.AddWithValue("@AdminID", AccountHolder.AccountID);
                        sqlCommand.Parameters.AddWithValue("@StudentNumber", studentInfo.StudentNo);
                        sqlCommand.Parameters.AddWithValue("@FirstName", studentInfo.FirstName);
                        sqlCommand.Parameters.AddWithValue("@MiddleName", studentInfo.MiddleName);
                        sqlCommand.Parameters.AddWithValue("@LastName", studentInfo.LastName);
                        sqlCommand.Parameters.AddWithValue("@ContactNo", studentInfo.ContactNo);
                        sqlCommand.Parameters.AddWithValue("@Email", studentInfo.Email);
                        sqlCommand.Parameters.AddWithValue("@Age", studentInfo.Age);
                        sqlCommand.Parameters.AddWithValue("@Address", studentInfo.Address);
                        sqlCommand.Parameters.AddWithValue("@ExistingScholarship", studentInfo.ExistingScholarship);
                        sqlCommand.Parameters.AddWithValue("@ParentsFullName", studentInfo.ParentsFullName);
                        sqlCommand.Parameters.AddWithValue("@ParentsContactNo", studentInfo.ParentsContactNo);
                        sqlCommand.Parameters.AddWithValue("@ParentsEmail", studentInfo.ParentsEmail);
                        sqlCommand.Parameters.AddWithValue("@Gender", studentInfo.Gender);
                        sqlCommand.Parameters.AddWithValue("@StudentType", studentInfo.StudentType);
                        sqlCommand.Parameters.AddWithValue("@CourseProgram", studentInfo.CourseProgram);
                        sqlCommand.Parameters.AddWithValue("@AcademicLevel", studentInfo.AcademicLevel);
                        sqlCommand.Parameters.AddWithValue("@AcademicTerm", studentInfo.AcademicTerm);
                        sqlCommand.Parameters.AddWithValue("@ProfilePicture", studentInfo.ProfilePicture);
                        sqlCommand.Parameters.AddWithValue("@PaymentMethod", studentInfo.PaymentMethod);
                        sqlCommand.Parameters.AddWithValue("@RegisterDate", studentInfo.RegisterDate);

                        int rowAffected = sqlCommand.ExecuteNonQuery();

                        return rowAffected > 0;
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting student to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        //Validate Fields
        public bool CheckFieldsFilled(out int age)
        {
            age = 0;
            try
            {
                TextBox[] reqTextbox = {
                txtFirstName,
                txtLastName,
                txtEmail,
                txtContactNo,
                txtAddress,
                txtPFullName,
                txtPEmail,
                txtPContactNo
                };
                ComboBox[] reqCombobox = {
                   cbAcadLevel, cbStudType, cbAcadTerm, cbCourse , cbGender, cbPaymentMethod
                };


                foreach (TextBox text in reqTextbox)
                {
                    if (string.IsNullOrWhiteSpace(text.Text))
                    {
                        MessageBox.Show("Please fill all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                foreach (ComboBox cb in reqCombobox)
                {
                    if (string.IsNullOrWhiteSpace(cb.Text) || !cb.Items.Contains(cb.Text))
                    {
                        MessageBox.Show($"Invalid value in {cb.Name}. Please select a valid value from the dropdown list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }

                //Validate Contact
                if (txtContactNo.Text.Length != 11 || !txtContactNo.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Invalid contact number. It should be 11 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txtPContactNo.Text.Length != 11 || !txtPContactNo.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Invalid Parent's contact number. It should be 11 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //Validate Email
                if (!txtEmail.Text.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Invalid email format. It should end with @gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //Validate Parent Email
                if (!txtPEmail.Text.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Invalid Parent's email format. It should end with @gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //Validate Age
                if (!int.TryParse(txtAge.Text, out age))
                {
                    MessageBox.Show("Invalid age. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //Validate StudentNumber
                string studentNo = txtStudentNumber.Text;
                if (!IsValidStudentNumberFormmat(studentNo))
                {
                    MessageBox.Show("Invalid Student Number format. It should be in the format '02000XXXXXX'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (IsStudentNumberAlreadyUsed(studentNo))
                {
                    MessageBox.Show("Student Number is already used by another student. Please choose a different number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool IsValidStudentNumberFormmat(string studentNo)
        {
            // Check if the student number starts with "02000"
            if (!studentNo.StartsWith("02000"))
            {
                return false;
            }

            // Check if the remaining characters are numeric
            string remainingDigits = studentNo.Substring(5);
            if (!remainingDigits.All(char.IsDigit))
            {
                return false;
            }

            // Check if the total length is 11 characters
            return studentNo.Length == 11;
        }

        private bool IsStudentNumberAlreadyUsed(string studentNo)
        {
            using (SqlConnection connectString = new(connectionString))
            {

                connectString.Open();
                string checkQuery = "SELECT COUNT(*) FROM StudentTBL WHERE StudentNumber = @StudentNo";

                using (SqlCommand sqlCommand = new(checkQuery, connectString))
                {
                    sqlCommand.Parameters.AddWithValue("@StudentNo", studentNo);

                    int count = (int)sqlCommand.ExecuteScalar();

                    return count > 0;
                }
            }

        }


        //
        //Discard those inserted input
        private void ClearAllInputs()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }

            }
        }

        public bool CheckUnsavedChanges()
        {
            if (hasUnsavedChanges)
            {

                DialogResult result = MessageBox.Show("You have unsaved changes. Do you want to discard them?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ClearAllInputs();
                }
                else
                {
                    return false;
                }
            }
            return true;

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            hasUnsavedChanges = true;
        }

        private void combobox_SelectedValueChanged(object sender, EventArgs e)
        {
            hasUnsavedChanges = true;
        }

        private void AddStudent_Leave(object sender, EventArgs e)
        {
            CheckUnsavedChanges();
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar) || txtContactNo.Text.Length >= MaxLength)
            {
                // If it's not a digit or exceeds the maximum length, suppress the key press
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) || txtAge.Text.Length >= MaxAgeLength)
            {
                e.Handled = true;
            }
        }

        private void txtPContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow backspace
            if (e.KeyChar == 8)
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) || txtPContactNo.Text.Length >= MaxLength)
            {
                // If it's not a digit or exceeds the maximum length, suppress the key press
                e.Handled = true;
            }
        }

        private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar) || txtStudentNumber.Text.Length >= MaxLength)
            {
                // If it's not a digit or exceeds the maximum length, suppress the key press
                e.Handled = true;
            }
        }
    }

}
