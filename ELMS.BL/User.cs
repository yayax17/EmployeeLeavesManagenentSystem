using System;

namespace ELMS.BL
{
    public class User
    {
        public static void DisplayHome()
        {
            ManageEmployeeLeaves employee = new ManageEmployeeLeaves();
           LeavesApproval emp = new LeavesApproval();
            Console.WriteLine("\nMENU");
            Console.WriteLine("a. Employee Leaves List \nb. Employee Leaves Form \nc. Add Employee Leave\nd. Cancel Leave Request\n0. Exit");
            Console.Write("\nEnter option letter:  ");
            char alphabet = Convert.ToChar(Console.ReadLine());

            switch (alphabet)
            {
                case 'a':
                    ManageEmployeeLeaves.EmployeeleavesList();
                    break;

                case 'b':
                    LeavesApproval.Employeeleavesform();
                    break;

                case 'c':
                    LeavesApproval.AddEmployeeLeave();
                    break;

                case 'd':
                    LeavesApproval.DeleteRequest();
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

       public static void Exit()
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
