using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlocknotCodeFirst.Helpers
{
    public static class Validation
    {
        public static bool IsTextFormat(string str)
        {
            return str.All(c => Char.IsLetter(c));
        }

        public static bool IsPhoneFormat(string phone)
        {
            if (phone.Length < 6)
                return false;
            if ((phone.Contains('+') && phone.First() == '+') || !phone.Contains('+'))
            {
                return phone.All(c => Char.IsNumber(c) || c == '+');
            }
            else return false;
        }

        public static bool IsEmailFormat(string email)
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
               + @"([-a-z0-9!#$%&'*/=^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
               + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            Regex ValidEmailRegex = new Regex(validEmailPattern, RegexOptions.IgnoreCase);

            return ValidEmailRegex.IsMatch(email);
        }
    }
}
