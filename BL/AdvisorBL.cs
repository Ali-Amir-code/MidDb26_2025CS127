using MidDb26_2025CS127.DAL;
using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MidDb26_2025CS127.BL
{
    internal class AdvisorBL
    {
        public static List<Advisor> GetAllAdvisors()
        {
            var advisors = AdvisorDAL.GetAllAdvisors();
            foreach (var advisor in advisors)
            {
                if (string.IsNullOrEmpty(advisor.LastName)) advisor.LastName = string.Empty;
                if (string.IsNullOrEmpty(advisor.Contact)) advisor.Contact = string.Empty;
                if (string.IsNullOrEmpty(advisor.DesignationLabel)) advisor.DesignationLabel = advisor.Designation.ToString();
            }

            return advisors;
        }

        public static List<Lookup> GetDesignationLookups()
        {
            return AdvisorDAL.GetDesignationLookups();
        }

        public static bool SaveAdvisor(Advisor advisor, bool isUpdate, out string errorMessage)
        {
            errorMessage = GetErrorMessage(advisor);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return false;
            }

            NormalizeAdvisor(advisor);
            bool success = isUpdate ? AdvisorDAL.UpdateAdvisor(advisor) : AdvisorDAL.AddAdvisor(advisor);
            if (!success)
            {
                errorMessage = "Unable to save advisor.";
            }

            return success;
        }

        public static bool DeleteAdvisor(int advisorId)
        {
            return AdvisorDAL.DeleteAdvisor(advisorId);
        }

        public static void DeleteAdvisors(IEnumerable<int> advisorIds)
        {
            if (advisorIds == null) return;

            foreach (var id in advisorIds)
            {
                AdvisorDAL.DeleteAdvisor(id);
            }
        }

        public static List<Advisor> FilterAdvisors(IEnumerable<Advisor> source, string firstName, string lastName, string designation, string salaryText, string contact, string email, int? gender, DateTime? dateOfBirth)
        {
            var query = (source ?? Enumerable.Empty<Advisor>()).AsEnumerable();

            if (!string.IsNullOrWhiteSpace(firstName))
            {
                query = query.Where(a => !string.IsNullOrWhiteSpace(a.FirstName) && a.FirstName.IndexOf(firstName, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(lastName))
            {
                query = query.Where(a => !string.IsNullOrWhiteSpace(a.LastName) && a.LastName.IndexOf(lastName, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(designation))
            {
                query = query.Where(a => !string.IsNullOrWhiteSpace(a.DesignationLabel) && a.DesignationLabel.IndexOf(designation, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            decimal parsedSalary;
            if (!string.IsNullOrWhiteSpace(salaryText) && decimal.TryParse(salaryText, out parsedSalary))
            {
                query = query.Where(a => a.Salary.HasValue && a.Salary.Value == parsedSalary);
            }

            if (!string.IsNullOrWhiteSpace(contact))
            {
                query = query.Where(a => !string.IsNullOrWhiteSpace(a.Contact) && a.Contact.IndexOf(contact, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                query = query.Where(a => !string.IsNullOrWhiteSpace(a.Email) && a.Email.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (gender.HasValue)
            {
                query = query.Where(a => a.Gender.HasValue && a.Gender.Value == gender.Value);
            }

            if (dateOfBirth.HasValue)
            {
                query = query.Where(a => a.DateOfBirth.HasValue && a.DateOfBirth.Value.Date == dateOfBirth.Value.Date);
            }

            return query.ToList();
        }

        public static string GetErrorMessage(Advisor advisor)
        {
            if (string.IsNullOrWhiteSpace(advisor.FirstName))
            {
                return "Missing first name. First name is required";
            }

            if (string.IsNullOrWhiteSpace(advisor.Email))
            {
                return "Missing email. Email is required";
            }

            if (!ValidationUtility.IsValidEmail(advisor.Email))
            {
                return "Email is not valid. Enter a valid email.";
            }

            if (advisor.Designation <= 0)
            {
                return "Missing designation. Designation is required.";
            }

            if (advisor.Salary.HasValue && advisor.Salary.Value < 0)
            {
                return "Salary cannot be negative.";
            }

            return string.Empty;
        }

        private static void NormalizeAdvisor(Advisor advisor)
        {
            advisor.FirstName = ValidationUtility.NormalizeRequired(advisor.FirstName);
            advisor.LastName = ValidationUtility.NormalizeOptional(advisor.LastName);
            advisor.Contact = ValidationUtility.NormalizeOptional(advisor.Contact);
            advisor.Email = ValidationUtility.NormalizeRequired(advisor.Email);

            if (advisor.Gender.HasValue)
            {
                if (advisor.Gender.Value == -1)
                {
                    advisor.Gender = null;
                }
                else if (advisor.Gender.Value == 0)
                {
                    advisor.Gender = 1;
                }
                else if (advisor.Gender.Value == 1 && advisor.Id <= 0)
                {
                    advisor.Gender = 2;
                }
            }
        }
    }
}
