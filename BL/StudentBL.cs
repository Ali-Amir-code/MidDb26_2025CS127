using MidDb26_2025CS127.DAL;
using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb26_2025CS127.BL
{
    public class StudentBL
    {
        public static List<Student> GetAllStudents()
        {
            List<Student> students = StudentDAL.GetAllStudents();
            foreach (Student student in students) {
                if (string.IsNullOrEmpty(student.LastName)) student.LastName = "";
                if (string.IsNullOrEmpty(student.Contact)) student.Contact = "";
                
            }

            return students;
        }


        public static bool AddStudent(Student student)
        {
            NormalizeStudent(student);
            
            return StudentDAL.AddStudent(student);
        }

        public static bool UpdateStudent(Student student)
        {
            NormalizeStudent(student);
            return StudentDAL.UpdateStudent(student);
        }

        public static bool DeleteStudent(int studentId)
        {
            return StudentDAL.DeleteStudent(studentId);
        }

        public static void DeleteStudents(IEnumerable<int> studentIds)
        {
            if (studentIds == null) return;
            foreach (var id in studentIds)
            {
                StudentDAL.DeleteStudent(id);
            }
        }

        public static List<Student> FilterStudents(IEnumerable<Student> source, string registrationNo, string firstName, string lastName, string contact, string email, int? gender, DateTime? dateOfBirth)
        {
            var query = (source ?? Enumerable.Empty<Student>()).AsEnumerable();

            if (!string.IsNullOrWhiteSpace(registrationNo))
            {
                query = query.Where(s => !string.IsNullOrWhiteSpace(s.RegistrationNo) && s.RegistrationNo.IndexOf(registrationNo, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(firstName))
            {
                query = query.Where(s => !string.IsNullOrWhiteSpace(s.FirstName) && s.FirstName.IndexOf(firstName, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(lastName))
            {
                query = query.Where(s => !string.IsNullOrWhiteSpace(s.LastName) && s.LastName.IndexOf(lastName, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(contact))
            {
                query = query.Where(s => !string.IsNullOrWhiteSpace(s.Contact) && s.Contact.IndexOf(contact, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                query = query.Where(s => !string.IsNullOrWhiteSpace(s.Email) && s.Email.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (gender.HasValue)
            {
                query = query.Where(s => s.Gender.HasValue && s.Gender.Value == gender.Value);
            }

            if (dateOfBirth.HasValue)
            {
                query = query.Where(s => s.DateOfBirth.HasValue && s.DateOfBirth.Value.Date == dateOfBirth.Value.Date);
            }

            return query.ToList();
        }

        public static bool SaveStudent(Student student, bool isUpdate, out string errorMessage)
        {
            errorMessage = GetErrorMessage(student);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return false;
            }

            bool success = isUpdate ? UpdateStudent(student) : AddStudent(student);
            if (!success)
            {
                errorMessage = "Unable to save student.";
            }

            return success;
        }

        public static bool IsValidStudent(Student student) {
            return !(
                String.IsNullOrEmpty(student.RegistrationNo) || 
                String.IsNullOrEmpty(student.Email) || 
                String.IsNullOrEmpty(student.FirstName) ||
                String.IsNullOrEmpty(student.RegistrationNo)
                );
        }

        public static string GetErrorMessage(Student student)
        {
            if (String.IsNullOrEmpty(student.RegistrationNo)) {
                return "Missing Registeration No. Registeration No. is required";
            }
            if (String.IsNullOrEmpty(student.FirstName))
            {
                return "Missing first name. First name is required";
            }
            if (String.IsNullOrEmpty(student.Email)) {
                return "Missing email. Email is required";
            }
            if (!ValidationUtility.IsValidEmail(student.Email))
            {
                return "Email is not valid. Enter a valid email.";
            }
            return "";
        }
        private static void NormalizeStudent(Student student)
        {
            student.RegistrationNo = ValidationUtility.NormalizeRequired(student.RegistrationNo);
            student.FirstName = ValidationUtility.NormalizeRequired(student.FirstName);
            student.LastName = ValidationUtility.NormalizeOptional(student.LastName);
            student.Contact = ValidationUtility.NormalizeOptional(student.Contact);
            student.Email = ValidationUtility.NormalizeRequired(student.Email);

            if (student.Gender.HasValue)
            {
                if (student.Gender.Value == -1)
                {
                    student.Gender = null;
                }
                else if (student.Gender.Value == 0)
                {
                    student.Gender = 1;
                }
                else if (student.Gender.Value == 1 && student.Id <= 0)
                {
                    student.Gender = 2;
                }
            }
        }
    }
}
