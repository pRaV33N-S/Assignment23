using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLibrary;
namespace MyApp
{
    internal class NumberValidation
    {
        public void ProcessNumber(string number)
        {
            var validator = new Validators();

            if (validator.IsValidPhoneNumber(number))
                Console.WriteLine($"Phone Number {number} is Valid");
            else
                Console.WriteLine($"Phone Number {number} is Not Valid");
        }
    }
}
