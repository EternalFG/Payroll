using LiteDB;
using Payroll.Core.Models;
using Payroll.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Core.Data.EmployeeDB
{
    public static class EmployeeTable
    {
        public static ILiteCollection<EmployeeBase> Employees;

        static EmployeeTable()
        {
            Employees = Program.Database.GetCollection<EmployeeBase>("Employees");
        }
        
        public static EmployeeBase FindEmployee(string employeeId)
        {
            return Employees.FindById(employeeId);
        }

        public static void AddEmployee(EmployeeBase employee)
        {
            Employees.Insert(employee);
        }

        public static bool UpdateEmployee(EmployeeBase employee)
        {
            return Employees.Update(employee);
        }

        public static bool DeleteEmployee(EmployeeBase employee)
        {
            return Employees.Delete(employee.Id);
        }
    }
}
