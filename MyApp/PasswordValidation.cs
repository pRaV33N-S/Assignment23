using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLibrary;
namespace MyApp
{
    internal class PasswordValidation
    {
        public void ProcessPassword(string password)
        {
            var validator = new Validators();
            if (validator.IsStrongPassword(password))
                Console.WriteLine($"Password {password} is Valid");
            else
                Console.WriteLine($"Password {password} is Not Valid");
        }
    }
}
