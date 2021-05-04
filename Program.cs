using System;
using System.Collections.Generic;

namespace EmployeeLeavesManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string mark = "login";
                Console.WriteLine("\nWELCOME TO EMPL0YEE MANAGEMENT SYSTEM");
                mark = Console.ReadLine();

                Console.WriteLine("     Log in to continue   ");
                Console.WriteLine("- -");
                Console.WriteLine("Enter Username:");
                string admin = Console.ReadLine();
                Console.WriteLine("Enter Password:");
                string pass = Console.ReadLine();

                if (admin == "login" && pass == "password")
                {
                    Console.WriteLine("\nLogin Successfully\n");
                    DisplayHome();
                }
                else
                {
                    Console.WriteLine("\nInvalid login. Please Try Again.\n");
                }
            }

            static void DisplayHome()
            {
                Console.WriteLine("\n MENU");
                Console.WriteLine(" \na. Employee Leaves List \nb. Employee Reports \nc  Searching Profile \nd  Custom Calendars \ne  Custom Time \nf. Exit");
                Console.WriteLine("\nEnter option letter:  ");
                char alphabet = Convert.ToChar(Console.ReadLine());

                switch (alphabet)
                {
                    case 'a':
                        EmployeeleavesList();
                        break;

                    case 'b':
                        EmployeeReports();
                        break;

                    case 'c':
                        SearchingProfile();
                        break;

                    case 'd':
                        CustomCalendars();
                        break;

                    case 'e':
                        CustomTime();
                        break;

                    case 'f':
                        Exit();
                        break;

                    default:
                        Console.WriteLine("Invalid. Please Try again. ");
                        break;
                }
                DisplayHome();
            }

            static void CustomTime()
            {
                Console.WriteLine("Sorry not available");
                Console.WriteLine("\nSystem is offline. Thank you!");

                Exit();
            }

            static void CustomCalendars()
            {
                Console.WriteLine("ENTER EMPLOYEE ID NUMBER: ");
                string id = Console.ReadLine();
                Console.WriteLine("--");
                Console.WriteLine("ENTER BIRTHDAY");
                string birthday = Console.ReadLine();
                Console.WriteLine("--");

                Console.WriteLine("ID NUMBER: " + id);
                Console.WriteLine("BIRTHDAY: " + birthday);
                Console.WriteLine("--");


                Console.WriteLine("MONTH WHEN EMPLOYEE LEAVES:");
                Console.WriteLine("");
                Console.WriteLine("a. JANUARY");
                Console.WriteLine("");
                Console.WriteLine("b. FEBRUARY");
                Console.WriteLine("");
                Console.WriteLine("c. MARCH");
                Console.WriteLine("");
                Console.WriteLine("d. APRIL");
                Console.WriteLine("");
                Console.WriteLine("e. MAY");
                Console.WriteLine("");
                Console.WriteLine("f. JUNE");
                Console.WriteLine("");
                Console.WriteLine("g. JULY");
                Console.WriteLine("");
                Console.WriteLine("8. AUGUST");
                Console.WriteLine("");
                Console.WriteLine("h. SEPTEMBER");
                Console.WriteLine("");
                Console.WriteLine("i. OCTOBER");
                Console.WriteLine("");
                Console.WriteLine("j. OCTOBER");
                Console.WriteLine("");
                Console.WriteLine("k. DECEMBER");
                Console.WriteLine("");

                Console.WriteLine("     ------------------------------------");
                Console.WriteLine("CHOOSE A letter WHEN employee LEAVE?");
                string letter = Console.ReadLine().ToLower();
                Console.WriteLine("EMPLOYEE NAME");
                string name1 = Console.ReadLine();
                Console.WriteLine("--");


                if (letter.Equals("a"))
                {
                    Console.WriteLine("EMPLOYEE NAME: " + name1);
                    Console.WriteLine("--");
                    Console.WriteLine("Added to employee leave.");
                    Console.WriteLine("--");
                    Console.WriteLine("THANK YOU. HAVE A GOOD DAY");
                }
                else if (letter.Equals("b"))
                {
                    Console.WriteLine("EMPLOYEE NAME: " + name1);
                    Console.WriteLine("--");
                    Console.WriteLine("Added to employee leave.");
                    Console.WriteLine("--");
                    Console.WriteLine("THANK YOU. HAVE A GOOD DAY");
                }
                else if (letter.Equals("c"))
                {
                    Console.WriteLine("EMPLOYEE NAME: " + name1);
                    Console.WriteLine("--");
                    Console.WriteLine("Added to employee leave.");
                    Console.WriteLine("--");
                    Console.WriteLine("THANK YOU. HAVE A GOOD DAY");
                }
                else if (letter.Equals("d"))
                {
                    Console.WriteLine("EMPLOYEE NAME: " + name1);
                    Console.WriteLine("--");
                    Console.WriteLine("Added to employee leave.");
                    Console.WriteLine("--");
                    Console.WriteLine("THANK YOU. HAVE A GOOD DAY");
                }
                else if (letter.Equals("e"))
                {
                    Console.WriteLine("EMPLOYEE NAME: " + name1);
                    Console.WriteLine("--");
                    Console.WriteLine("Added to employee leave.");
                    Console.WriteLine("--");
                    Console.WriteLine("THANK YOU. HAVE A GOOD DAY");
                }
                else if (letter.Equals("f"))
                {
                    Console.WriteLine("EMPLOYEE NAME: " + name1);
                    Console.WriteLine("--");
                    Console.WriteLine("Added to employee leave.");
                    Console.WriteLine("--");
                    Console.WriteLine("THANK YOU. HAVE A GOOD DAY");
                }
                else if (letter.Equals("g"))
                {
                    Console.WriteLine("EMPLOYEE NAME: " + name1);
                    Console.WriteLine("--");
                    Console.WriteLine("Added to employee leave.");
                    Console.WriteLine("--");
                    Console.WriteLine("THANK YOU. HAVE A GOOD DAY");
                }
                else if (letter.Equals("h"))
                {
                    Console.WriteLine("EMPLOYEE NAME: " + name1);
                    Console.WriteLine("--");
                    Console.WriteLine("Added to employee leave.");
                    Console.WriteLine("--");
                    Console.WriteLine("THANK YOU. HAVE A GOOD DAY");
                }
                else if (letter.Equals("i"))
                {
                    Console.WriteLine("EMPLOYEE NAME: " + name1);
                    Console.WriteLine("--");
                    Console.WriteLine("Added to employee leave.");
                    Console.WriteLine("--");
                    Console.WriteLine("THANK YOU. HAVE A GOOD DAY");
                }
                else if (letter.Equals("j"))
                {
                    Console.WriteLine("EMPLOYEE NAME: " + name1);
                    Console.WriteLine("--");
                    Console.WriteLine("Added to employee leave.");
                    Console.WriteLine("--");
                }
                else
                {
                    Console.WriteLine("Invalid. Please try again.");
                }

                Console.ReadLine();

            }

            static void SearchingProfile()
            {
                Console.WriteLine("Sorry not available");
                Console.WriteLine("\nSystem is offline. Thank you!");

                Exit();
            }

            static void Exit()
            {
                Console.WriteLine("\nWould you like to close the program? ( YES / NO ) ");
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
            static void EmployeeReports()
            {
                Console.WriteLine("Sorry not available");
                Console.WriteLine("\nSystem is offline. Thank you!");

                Exit();
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


        }
    }