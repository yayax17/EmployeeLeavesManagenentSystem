using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.BL
{
    class ManageEmployeeLeaves
    {
         public static void EmployeeleavesList()
        {
            Console.WriteLine("Employee leaves List");

            List<string> employeeleaveslist = new List<string>() { "Allen Marvin Eder", "Henry Sy", "Aika Uy", "Aljun Linaza", "Ismael Mmorno" };

            foreach (var names in employeeleaveslist)
            {
                Console.WriteLine(names);
            }
            User.Exit();
        }
    }
}
