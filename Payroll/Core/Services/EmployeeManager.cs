using Payroll.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Core.Services
{
    public class EmployeeManager
    {
        public Employee CreateEmployee(string name, string surname, byte age, EmployeeGender gender, decimal baseSalary, DateTime dateTime)
        {
            return new Employee(name, surname, age, gender, baseSalary, dateTime);
        }

        public Manager CreateManager(string name, string surname, byte age, EmployeeGender gender, decimal baseSalary, DateTime dateTime)
        {
            return new Manager(name, surname, age, gender, baseSalary, dateTime);
        }

        public Salesman CreateSalesman(string name, string surname, byte age, EmployeeGender gender, decimal baseSalary, DateTime dateTime)
        {
            return new Salesman(name, surname, age, gender, baseSalary, dateTime);
        }


        public void AddSubordinate(IEmployee employee, IEmployee subordinate)
        {
            if (employee is Employee)
            {
                Console.WriteLine("Нет");
                return;
            }
            if (employee is Manager manager)
            {
                var sub = manager.Subordinates.FirstOrDefault(s => s.Name.Equals(subordinate.Name));
                if (sub == null)
                {
                    if (sub is Employee emp)
                    {
                        manager.Subordinates.Add(emp);
                    }
                }
                else
                {
                    Console.WriteLine("Already a subordinate");
                }
            }
        }
    }
}
