using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class UserName
    {
        public void CreateUser(string username, string email)
        {
            Console.WriteLine($"Creating user: {username} ({email})");
        }
    }
}
