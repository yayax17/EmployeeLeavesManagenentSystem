using System;
using ELMS.BL;

namespace ELMS.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("\nWELCOME TO EMPLOYEE MANAGEMENT SYSTEM\n");
            Console.WriteLine("     Log in to continue   \n\n");
            Console.Write("Enter Username: ");
            string admin = Console.ReadLine();
            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            if (admin == "login" && pass == "password")
            {
                Console.WriteLine("\nLogin Successfully.\n");
                User.DisplayHome();
            }
            else
            {
                Console.WriteLine("\nInvalid login. Please Try Again.\n");
            }
        }
    }
}
