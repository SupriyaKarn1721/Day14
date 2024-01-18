using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valiateuser
{
    class ValidateUser
    {
        string u;
        string p;
        public void GetDetails()
        {
            Console.WriteLine("Enter username: ");
            u = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            p = Console.ReadLine();
        }
        public bool ValidateDetails(string username,string password)
        {
            if (username == "supriya" && password =="123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayDetails()
        {
            if (ValidateDetails(u, p))
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Login failed");
            }
        }
        

    }
}
