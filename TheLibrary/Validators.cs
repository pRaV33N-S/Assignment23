using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLibrary
{
    public class Validators
    {
        public bool IsValidEmail(string email)
        {
            return !string.IsNullOrEmpty(email) && email.Contains("@");
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrEmpty(phoneNumber) && phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }

        public bool IsStrongPassword(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Length >= 8;
        }
    }
}
