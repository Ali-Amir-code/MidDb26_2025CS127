using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb26_2025CS127.Utilities
{
    internal class ValidationUtility
    {
        public static string NormalizeRequired(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }

        public static string NormalizeOptional(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? string.Empty : value.Trim();
        }

        public static bool IsValidEmail(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            value = value.Trim();

            int atIndex = value.IndexOf('@');
            if (atIndex <= 0 || value.LastIndexOf('@') != atIndex)
            {
                return false;
            }

            string domain = value.Substring(atIndex + 1);
            int dotIndex = domain.IndexOf('.');
            if (dotIndex <= 0 || dotIndex >= domain.Length - 1)
            {
                return false;
            }

            return true;
        }
    }
}
