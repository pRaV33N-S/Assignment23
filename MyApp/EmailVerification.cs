using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLibrary;
namespace MyApp
{
    internal class EmailVerification
    {
        public void ProcessEmail(string email)
        {
            var validator = new Validators();
            if (validator.IsValidEmail(email))
                Console.WriteLine($"Email '{email}' is valid.");
            else
                Console.WriteLine($"Email '{email}' is not valid.");
        }
    }
}
