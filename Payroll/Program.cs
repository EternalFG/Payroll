using Payroll.Core.Models;
using Payroll.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public static class Program
    {
        //[STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Authorization());
            EmployeeManager employeeManager = new EmployeeManager();
            Manager manager = employeeManager.CreateManager("Maks", "Gradov", 24, EmployeeGender.Man, 23000, DateTime.Now);
            Employee employee = employeeManager.CreateEmployee("Maks", "Gradov", 24, EmployeeGender.Man, 23000, DateTime.Now);
            employeeManager.AddSubordinate(employee, manager);
            employeeManager.AddSubordinate(manager, new Salesman("ds", "fsf", 22, EmployeeGender.Women, 34000, DateTime.Now));
            Console.ReadLine();

        }
    }
}
