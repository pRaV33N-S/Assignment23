using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLibrary;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userName = new UserName();
            userName.CreateUser("Praveen", "praveen2001@gmail.com");

            var email = new EmailVerification();
            email.ProcessEmail("notAnEmail007");
            email.ProcessEmail("nowThatsAnEmail@gmail.com");

            var number = new NumberValidation();
            number.ProcessNumber("8908954421");
            number.ProcessNumber("2174387");

            var password = new PasswordValidation();
            password.ProcessPassword("Tmz@2001Rockafella");
            password.ProcessPassword("noPass");

            Console.ReadKey();
        }
    }
}
