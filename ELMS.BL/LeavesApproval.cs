using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.BL
{
    class LeavesApproval
    {
        public static void Employeeleavesform()
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
                Console.WriteLine("Pending Request: " + en + "\nWait for 2-3 days for the approval. Thank you.");
            }
            User.Exit();
        }
        public static void AddEmployeeLeave()
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
        public static void DeleteRequest()
        {
            Console.WriteLine("ENTER EMPLOYEE ID NUMBER: ");
            string id = Console.ReadLine();
            Console.WriteLine("ENTER DATE OF REQUEST: ");
            string date = Console.ReadLine();
            Console.WriteLine("********");
            Console.WriteLine("Cancelled Request ");
        }
    }
}
