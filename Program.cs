using System;
using System.Collections.Generic;

namespace EmployeeLeavesManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWELCOME TO EMPLOYEE MANAGEMENT SYSTEM\n");
            Console.WriteLine("     Log in to continue   \n\n");
            Console.Write("Enter Username: ");
            string admin = Console.ReadLine();
            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            if (admin == "login" && pass == "password")
            {
                Console.WriteLine("\nLogin Successfully.\n");
                DisplayHome();
            }
            else
            {
                Console.WriteLine("\nInvalid login. Please Try Again.\n");
            }
        }

        static void DisplayHome()
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("a. Employee Leaves List \nb. Employee Leaves Form \nc. Add Employee Leave\nd. Cancel Leave Request\n0. Exit");
            Console.Write("\nEnter option letter:  ");
            char alphabet = Convert.ToChar(Console.ReadLine());

            switch (alphabet)
            {
                case 'a':
                    EmployeeleavesList();
                    break;

                case 'b':
                    Employeeleavesform();
                    break;

                case 'c':
                    AddEmployeeLeave();
                    break;

                case 'd':
                    DeleteRequest();
                    break;

                case '0':
                    Exit();
                    break;

                default:
                    Console.WriteLine("Invalid. Please Try again. ");
                    break;
            }
            DisplayHome();
        }

        static void EmployeeleavesList()
        {
            Console.WriteLine("Employee leaves List");

            List<string> employeeleaveslist = new List<string>() { "Allen Marvin Eder", "Henry Sy", "Aika Uy", "Aljun Linaza", "Ismael Mmorno" };

            foreach (var names in employeeleaveslist)
            {
                Console.WriteLine(names);
            }
            Exit();
        }
        static void Employeeleavesform()
        {
            var marky = new List<string>();
            Console.Write("Employee Id Number: ");
            string id = Console.ReadLine();

            Console.Write("Employee Name: ");
            string n = Console.ReadLine();

            Console.Write("Leave Request: ");
            string l = Console.ReadLine();

            Console.Write("Requested Date: ");
            string d = Console.ReadLine();


            Console.WriteLine("\nLEAVE REQUEST FORM");
            Console.WriteLine("Employee Id Number: " + id + "\nEmployee Name: " + n + "\nLeave Request: " + l + "\nRequested Date: " + d + "\n Employee leaves has been requested. ");

            marky.Add(n);
            foreach (var en in marky)
            {
                Console.WriteLine("Pending Request: " + en + "\nWait for 2-3 days for the approval. Thank you." );
            }

            Exit();
        }

        static void AddEmployeeLeave()
        {
            Console.WriteLine("ENTER EMPLOYEE ID NUMBER: ");
            string id = Console.ReadLine();
            Console.WriteLine("ENTER BIRTHDAY: ");
            string birthday = Console.ReadLine();
            Console.WriteLine("--");
            Console.WriteLine("ID NUMBER: " + id);
            Console.WriteLine("BIRTHDAY: " + birthday);

            Console.WriteLine("CHOOSE MONTH WHEN EMPLOYEE LEAVES: ");
            Console.WriteLine("a. JANUARY\nb. FEBRUARY\nc. MARCH\nd. APRIL\ne. MAY\nf. JUNE\ng. JULY\nh. AUGUST\ni. SEPTEMBER\nj. OCTOBER\nk. OCTOBER\nl. DECEMBER");
            string letter = Console.ReadLine().ToLower();
            Console.WriteLine("EMPLOYEE NAME: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("--");
            Console.WriteLine("Added to Employee Leave List. \nTHANK YOU. HAVE A GOOD DAY.");
        }

      
        static void DeleteRequest()
        {
            Console.WriteLine("ENTER EMPLOYEE ID NUMBER: ");
            string id = Console.ReadLine();
            Console.WriteLine("ENTER DATE OF REQUEST: ");
            string date = Console.ReadLine();
            Console.WriteLine("********");
            Console.WriteLine("Cancelled Request ");
        }
        static void Exit()
        {
            Console.WriteLine("\nWould you like to close the program? ( yes / no ) ");
            String a = Console.ReadLine();

            if (a.Equals("yes"))
            {
                Console.WriteLine(" The System is going to shut down");
                Environment.Exit(0);
            }
            else if (a.Equals("no"))
            {
                Console.WriteLine("");
                DisplayHome();
            }
            else
            {
                Console.WriteLine("Invalid. Please Try again. ");
            }
        }
        

    }
}
