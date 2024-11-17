using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using static Aspose.Pdf.Text.TextOptions;
using static STI_Join.DatabaseHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Aspose.Pdf.Facades;

namespace STI_Join
{
    public partial class EditStudentFrm : System.Windows.Forms.Form
    {
        private const int MaxAgeLength = 2;
        private const int MaxLength = 11;
        private int studentID;
        private StudentInfo studentInfo;
        private bool isImageUploaded = false;
        private bool changesMade;
        private bool isGenderChanged = false;

        public EditStudentFrm(int studentID)
        {
            InitializeComponent();
            this.studentID = studentID;

            LoadStudentDetails();
            SetRoundedForm();
            SetHandCursorForButtons(this);
            changesMade = false;
            btnUpdate.Enabled = false;
        }



        private void SetRoundedForm()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 15, 15, 180, 90); // Top-left corner
            path.AddArc(Width - 15, 0, 15, 15, 270, 90); // Top-right corner
            path.AddArc(Width - 15, Height - 15, 15, 15, 0, 90); // Bottom-right corner
            path.AddArc(0, Height - 15, 15, 15, 90, 90); // Bottom-left corner
            path.CloseFigure();

            Region = new Region(path);
        }


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

        // No Changes in Update
        private void EnableUpdateButton()
        {
            btnUpdate.Enabled = StudentInfoChanged();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            EnableUpdateButton();
        }

        private void Comboboxes_SelectedValueChanged_1(object sender, EventArgs e)
        {
            EnableUpdateButton();
        }


        private bool StudentInfoChanged()
        {

            if (studentInfo == null)
            {
                return true;
            }

            bool firstNameChanged = txtFirstName.Text != studentInfo.FirstName;
            bool middleNameChanged = txtMName.Text != studentInfo.MiddleName;
            bool lastNameChanged = txtLastName.Text != studentInfo.LastName;
            bool contactNoChanged = txtContactNo.Text != studentInfo.ContactNo;
            bool emailChanged = txtEmail.Text != studentInfo.Email;
            bool ageChanged = txtAge.Text != studentInfo.Age.ToString();
            bool addressChanged = txtAddress.Text != studentInfo.Address;
            bool existScholarChanged = txtExistScholar.Text != studentInfo.ExistingScholarship;
            bool pFullNameChanged = txtPFullName.Text != studentInfo.ParentsFullName;
            bool pContactNoChanged = txtPContactNo.Text != studentInfo.ParentsContactNo;
            bool pEmailChanged = txtPEmail.Text != studentInfo.ParentsEmail;
            bool genderChanged = cbGender.Text != studentInfo.Gender;
            bool studentTypeChanged = cbStudType.Text != studentInfo.StudentType;
            bool courseProgramChanged = cbCourse.Text != studentInfo.CourseProgram;
            bool acadLevelChanged = cbAcadLevel.Text != studentInfo.AcademicLevel;
            bool acadTermChanged = cbAcadTerm.Text != studentInfo.AcademicTerm;
            bool paymentMethodChanged = cbPaymentMethod.Text != studentInfo.PaymentMethod;

            bool profilePictureChanged = isImageUploaded || isGenderChanged;


            // Check if any of the fields have changed
            bool fieldsChanged = firstNameChanged || middleNameChanged || lastNameChanged ||
                   contactNoChanged || emailChanged || ageChanged || addressChanged ||
                   existScholarChanged || pFullNameChanged || pContactNoChanged ||
                   pEmailChanged || genderChanged || studentTypeChanged ||
                   courseProgramChanged || acadLevelChanged || acadTermChanged || paymentMethodChanged;

            changesMade = fieldsChanged || profilePictureChanged;

            return changesMade;
        }


        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckFieldsFilled(out int age))
            {
                bool updateSuccessful = UpdateStudent();

                if (updateSuccessful)
                {
                    MessageBox.Show("Student updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }

        public bool UpdateStudent()
        {
            try
            {
                using (SqlConnection sqlConnection = new(DatabaseHelper.connectionString))
                {
                    sqlConnection.Open();
                    string updateQuery = @"
                    UPDATE StudentTBL
                    SET
                    FirstName = @FirstName,
                    MiddleName = @MiddleName,
                    LastName = @LastName,
                    ContactNo = @ContactNo,
                    Email = @Email,
                    Age = @Age,
                    Address = @Address,
                    ExistingScholarship = @ExistingScholarship,
                    ParentsFullName = @ParentsFullName,
                    ParentsContactNo = @ParentsContactNo,
                    ParentsEmail = @ParentsEmail,
                    Gender = @Gender,
                    StudentType = @StudentType,
                    CourseProgram = @CourseProgram,
                    AcademicLevel = @AcademicLevel,
                    AcademicTerm = @AcademicTerm,
                    PaymentMethod = @PaymentMethod,
                    ProfilePicture = @ProfilePicture
                    WHERE
                    StudentID = @StudentID";

                    using (SqlCommand sqlCommand = new(updateQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        sqlCommand.Parameters.AddWithValue("@MiddleName", txtMName.Text);
                        sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        sqlCommand.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                        sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                        sqlCommand.Parameters.AddWithValue("@Age", txtAge.Text);
                        sqlCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
                        sqlCommand.Parameters.AddWithValue("@ExistingScholarship", txtExistScholar.Text);
                        sqlCommand.Parameters.AddWithValue("@ParentsFullName", txtPFullName.Text);
                        sqlCommand.Parameters.AddWithValue("@ParentsContactNo", txtContactNo.Text);
                        sqlCommand.Parameters.AddWithValue("@ParentsEmail", txtPEmail.Text);
                        sqlCommand.Parameters.AddWithValue("@Gender", cbGender.Text);
                        sqlCommand.Parameters.AddWithValue("@StudentType", cbStudType.Text);
                        sqlCommand.Parameters.AddWithValue("@CourseProgram", cbCourse.Text);
                        sqlCommand.Parameters.AddWithValue("@AcademicLevel", cbAcadLevel.Text);
                        sqlCommand.Parameters.AddWithValue("@AcademicTerm", cbAcadTerm.Text);
                        sqlCommand.Parameters.AddWithValue("@PaymentMethod", cbPaymentMethod.Text);

                        // Check if a new image is uploaded
                        if (isImageUploaded)
                        {
                            // Convert the new image to byte array and assign it to the parameter
                            using (MemoryStream ms = new MemoryStream())
                            {
                                picStudent.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                sqlCommand.Parameters.AddWithValue("@ProfilePicture", ms.ToArray());
                            }
                        }
                        else
                        {
                            // Use the existing image data if no new image is uploaded
                            sqlCommand.Parameters.AddWithValue("@ProfilePicture", studentInfo.ProfilePicture);
                        }

                        sqlCommand.Parameters.AddWithValue("@StudentID", studentID);

                        bool isUpdateNeeded = StudentInfoChanged();

                        if (isUpdateNeeded)
                        {
                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Reset changesMade after successful update
                                changesMade = false;
                                btnUpdate.Enabled = false;
                                return true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No changes to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        return false;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CheckFieldsFilled(out int age)
        {
            age = 0;
            try
            {
                System.Windows.Forms.TextBox[] reqTextbox = {
                txtFirstName,
                txtLastName,
                txtEmail,
                txtContactNo,
                txtAddress,
                txtPFullName,
                txtPEmail,
                txtPContactNo
                };
                System.Windows.Forms.ComboBox[] reqCombobox = {
                   cbAcadLevel, cbStudType, cbAcadTerm, cbCourse , cbGender, cbPaymentMethod
                };


                foreach (System.Windows.Forms.TextBox text in reqTextbox)
                {
                    if (string.IsNullOrWhiteSpace(text.Text))
                    {
                        MessageBox.Show("Please fill all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                foreach (System.Windows.Forms.ComboBox cb in reqCombobox)
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

                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Populate Combobox
        private void EditStudentFrm_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

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

            for (int i = 0; i < arrPrograms.Length; i++)
            {
                cbCourse.Items.Add(arrPrograms[i]);
            }

            // Academic Level
            string[] arrAcadLevel = { "1st Year", "2nd Year", "3rd Year", "4th Year" };
            for (int i = 0; i < arrAcadLevel.Length; i++)
            {
                cbAcadLevel.Items.Add(arrAcadLevel[i]);
            }

            //Student Type
            string[] arrStudentType = { "Regular", "Irregular" };
            for (int i = 0; i < arrStudentType.Length; i++)
            {
                cbStudType.Items.Add(arrStudentType[i]);
            }

            //Academic Term
            string[] arrAcadTerm = { "1st Term", "2nd Term" };
            for (int i = 0; i < arrAcadTerm.Length; i++)
            {
                cbAcadTerm.Items.Add(arrAcadTerm[i]);
            }
            //Gender
            string[] arrGender = { "Male", "Female", "Rather not say" };
            for (int i = 0; i < arrGender.Length; i++)
            {
                cbGender.Items.Add(arrGender[i]);
            }
            //Payment Method
            string[] arrPaymentMethod = { "Full Payment", "Installment" };
            for (int i = 0; i < arrPaymentMethod.Length; i++)
            {
                cbPaymentMethod.Items.Add(arrPaymentMethod[i]);
            }
        }

        //Show Student Info
        private void LoadStudentDetails()
        {
            try
            {
                using (SqlConnection sqlConnection = new(DatabaseHelper.connectionString))
                {

                    sqlConnection.Open();
                    string query = $"SELECT * FROM StudentTBL WHERE StudentID = {studentID}";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {

                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.Read())
                        {
                            studentInfo = new StudentInfo
                            {
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                StudentNo = reader["StudentNumber"].ToString(),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                MiddleName = reader["MiddleName"].ToString(),
                                ContactNo = reader["ContactNo"].ToString(),
                                Email = reader["Email"].ToString(),
                                Age = Convert.ToInt32(reader["Age"]),
                                Address = reader["Address"].ToString(),
                                ExistingScholarship = reader["ExistingScholarship"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                StudentType = reader["StudentType"].ToString(),
                                CourseProgram = reader["CourseProgram"].ToString(),
                                AcademicLevel = reader["AcademicLevel"].ToString(),
                                AcademicTerm = reader["AcademicTerm"].ToString(),
                                ParentsFullName = reader["ParentsFullName"].ToString(),
                                ParentsContactNo = reader["ParentsContactNo"].ToString(),
                                ParentsEmail = reader["ParentsEmail"].ToString(),
                                PaymentMethod = reader["PaymentMethod"].ToString(),
                                ProfilePicture = reader["ProfilePicture"] as byte[],
                                RegisterDate = Convert.ToDateTime(reader["RegisterDate"])
                            };

                            txtStudentNumber.Text = studentInfo.StudentNo;
                            txtFirstName.Text = studentInfo.FirstName;
                            txtLastName.Text = studentInfo.LastName;
                            txtMName.Text = studentInfo.MiddleName;
                            txtContactNo.Text = studentInfo.ContactNo;
                            txtEmail.Text = studentInfo.Email;
                            txtAge.Text = studentInfo.Age.ToString();
                            txtAddress.Text = studentInfo.Address;
                            txtExistScholar.Text = studentInfo.ExistingScholarship;
                            txtPFullName.Text = studentInfo.ParentsFullName;
                            txtPContactNo.Text = studentInfo.ParentsContactNo;
                            txtPEmail.Text = studentInfo.ParentsEmail;
                            cbGender.Text = studentInfo.Gender;
                            cbStudType.Text = studentInfo.StudentType;
                            cbCourse.Text = studentInfo.CourseProgram;
                            cbAcadLevel.Text = studentInfo.AcademicLevel;
                            cbAcadTerm.Text = studentInfo.AcademicTerm;
                            cbPaymentMethod.Text = studentInfo.PaymentMethod;
                            dtRegDate.Value = studentInfo.RegisterDate;

                            byte[] imageData = reader["ProfilePicture"] as byte[];

                            if (imageData != null && imageData.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    picStudent.Image = System.Drawing.Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                // If there is no image in the database, set a default image
                                picStudent.Image = Properties.Resources.avatarPic;
                            }


                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Image
        //Upload Photo
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
                        System.Drawing.Image tempImage = new Bitmap(openFileDialog.FileName);

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
                        EnableUpdateButton();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImage();
            btnClear.Visible = false;
            EnableUpdateButton();
        }

        //Convert Image To Byte
        private byte[] ConvertImageToByteArray(System.Drawing.Image image)
        {
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(image), "Image cannot be null.");
            }
        }

        private void ClearImage()
        {

            DialogResult result = MessageBox.Show("Are you sure you want to clear the image?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (cbGender.SelectedItem != null)
                {
                    string selectedGender = cbGender.SelectedItem.ToString();
                    SetDefaultPictureByGender(selectedGender);
                }
                else if (!string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    string enteredGender = cbGender.Text;
                    SetDefaultPictureByGender(enteredGender);
                }
                else
                {
                    picStudent.Image = Properties.Resources.avatarPic;
                }

                isImageUploaded = true;
                isGenderChanged = false;

                // Call EnableUpdateButton to update the state of btnUpdate
                EnableUpdateButton();
            }
        }

        private void SetDefaultPictureByGender(string gender)
        {
            if (gender.ToLower() == "male")
            {
                picStudent.Image = Properties.Resources.avatarPic;
            }
            else if (gender.ToLower() == "female")
            {
                picStudent.Image = Properties.Resources.avatarGirlPic;
            }
            else
            {
                picStudent.Image = Properties.Resources.avatarPic;
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

        //Generate Word
        private void GeneratePdfFile(string filePath)
        {

            string fName = studentInfo.FirstName;
            string mName = studentInfo.MiddleName;
            string lName = studentInfo.LastName;
            string contactNo = studentInfo.ContactNo;
            string eMail = studentInfo.Email;
            string existingScholarship = studentInfo.ExistingScholarship;
            string pFullName = studentInfo.ParentsFullName;
            string pContactNo = studentInfo.ParentsContactNo;
            string pEmail = studentInfo.ParentsEmail;
            string Age = studentInfo.Age.ToString();
            string sGender = studentInfo.Gender;
            string sAddress = studentInfo.Address;
            string studType = studentInfo.StudentType;
            string courseProg = studentInfo.CourseProgram;
            string acadLevel = studentInfo.AcademicLevel;
            string acadTerm = studentInfo.AcademicTerm;
            string paymentMethod = studentInfo.PaymentMethod;
            DateTime registerDate = dtRegDate.Value;


            // Individual Fields and Values
            string[] fieldNames = {
            "First Name", "Middle Name", "Last Name", "Contact No", "Email",
            "Existing Scholarship", "Parents Full Name", "Parents Contact No",
            "Parents Email", "Age", "Gender", "Address", "Student Type",
            "Course", "Academic Level", "Academic Term",
            "Payment Method", "Register Date"
            };

            string[] fieldValues = {
            fName, mName, lName, contactNo, eMail, existingScholarship,
            pFullName, pContactNo, pEmail, Age, sGender, sAddress, studType,
            courseProg, acadLevel, acadTerm, paymentMethod, registerDate.ToString()
            };

            try
            {

                Document pdfDocument = new Document();
                Aspose.Pdf.Page pdfPage = pdfDocument.Pages.Add();

                TextBuilder textBuilder = new TextBuilder(pdfPage);

                //Title
                TextFragment titleFragment = new TextFragment("Student Information");
                titleFragment.TextState.Font = FontRepository.FindFont("Segoe UI");
                titleFragment.TextState.FontSize = 24;
                titleFragment.TextState.FontStyle = FontStyles.Bold;
                titleFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromArgb(28, 84, 197);

                //Student Number:
                TextFragment studentNumberFragment = new TextFragment("Student Number: " + studentInfo.StudentNo);
                studentNumberFragment.TextState.Font = FontRepository.FindFont("Segoe UI");
                studentNumberFragment.TextState.FontSize = 14;
                studentNumberFragment.TextState.FontStyle = FontStyles.Bold;
                studentNumberFragment.TextState.ForegroundColor = Aspose.Pdf.Color.Black;

                TextFragment NextLine = new TextFragment(" ");

                //SECTION//
                // TITLE
                pdfPage.Paragraphs.Add(titleFragment);
                pdfPage.Paragraphs.Add(NextLine);
                pdfPage.Paragraphs.Add(NextLine);

                // Fields and Values
                pdfPage.Paragraphs.Add(studentNumberFragment);
                pdfPage.Paragraphs.Add(NextLine);
                for (int i = 0; i < fieldNames.Length; i++)
                {
                    //Fields
                    TextFragment fieldsFragment = new TextFragment($"{fieldNames[i]}: ");
                    fieldsFragment.TextState.Font = FontRepository.FindFont("Segoe UI");
                    fieldsFragment.TextState.FontSize = 11;
                    fieldsFragment.TextState.FontStyle = FontStyles.Bold;
                    fieldsFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromArgb(89, 93, 105);

                    //Values
                    TextFragment valueFragment = new TextFragment(fieldValues[i]);
                    valueFragment.TextState.Font = FontRepository.FindFont("Segoe UI");
                    valueFragment.TextState.FontSize = 11;
                    valueFragment.TextState.FontStyle = FontStyles.Regular;
                    valueFragment.TextState.ForegroundColor = Aspose.Pdf.Color.Black;

                    pdfPage.Paragraphs.Add(fieldsFragment);
                    pdfPage.Paragraphs.Add(valueFragment);
                    pdfPage.Paragraphs.Add(NextLine);
                }

                // Add the profile picture
                System.Drawing.Image ProfilePic = picStudent.Image;
                byte[] profilePictureData = ConvertImageToByteArray(ProfilePic);
                MemoryStream imageStream = new MemoryStream(profilePictureData);

                double pageWidth = pdfPage.Rect.Width;
                double pageHeight = pdfPage.Rect.Height;

                // Specify the size of the image
                double imageWidth = 200;  // Adjust this based on your image size
                double imageHeight = 200; // Adjust this based on your image size

                double lowerLeftX = pageWidth - imageWidth;
                double lowerLeftY = 0;

                double upperRightX = pageWidth;
                double upperRightY = imageHeight;

                Aspose.Pdf.Rectangle rectangle = new Aspose.Pdf.Rectangle(lowerLeftX, lowerLeftY, upperRightX, upperRightY);

                pdfPage.AddImage(imageStream, rectangle);


                pdfDocument.Save(filePath);

                MessageBox.Show("PDF file generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Documents (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.Title = "Save PDF File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GeneratePdfFile(saveFileDialog.FileName);
            }
        }

        //EXIT
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtPContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar) || txtAge.Text.Length >= MaxAgeLength)
            {
                // If it's not a digit or exceeds the maximum length, suppress the key press
                e.Handled = true;
            }
        }
    }
}
