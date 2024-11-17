using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace STI_Join
{
    public class StudentInfo
    {
        public int StudentID { get; set; }
        public string StudentNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string ExistingScholarship { get; set; }
        public string Gender { get; set; }
        public string StudentType { get; set; }
        public string CourseProgram { get; set; }
        public string AcademicLevel { get; set; }
        public string AcademicTerm { get; set; }
        public string ParentsFullName { get; set; }
        public string ParentsEmail { get; set; }
        public string ParentsContactNo { get; set; }
        public DateTime RegisterDate { get; set; }
        public string PaymentMethod { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}
