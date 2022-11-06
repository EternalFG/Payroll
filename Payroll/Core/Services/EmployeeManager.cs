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


        public void AddSubordinate(IEmployee changeableEmployee, IEmployee subordinateAdded)
        {
            if (changeableEmployee is Employee)
            {
                return;
            }
            if (changeableEmployee is Manager manager)
            {
                if (subordinateAdded is Employee employee)
                {
                    if (manager.Subordinates.FirstOrDefault(s => s.Name.Equals(employee.Name)) != null)
                    {
                        Console.WriteLine("Already a subordinate");
                    }
                    else
                    {
                        manager.Subordinates.Add(employee);
                    }
                }
            }
            if (changeableEmployee is Salesman salesman)
            {
                if (salesman.Subordinates.FirstOrDefault(s => s.Name.Equals(subordinateAdded.Name)) != null)
                {
                    Console.WriteLine("Already a subordinate");
                }
                else
                {
                    salesman.Subordinates.Add(subordinateAdded);
                }
            }
        }

        public void RemoveSubordinate(IEmployee changeableEmployee, IEmployee subordinateAdded)
        {
            if (changeableEmployee is Employee)
            {
                return;
            }
            if (changeableEmployee is Manager manager)
            {
                if (manager.Subordinates.FirstOrDefault(s => s.Name.Equals(subordinateAdded.Name)) != null)
                {
                    manager.Subordinates.Remove((Employee)subordinateAdded);
                }
                else
                {
                    Console.WriteLine("Subordinate not found");
                }
            }
            if (changeableEmployee is Salesman salesman)
            {
                var subordinate = salesman.Subordinates.FirstOrDefault(s => s.Name.Equals(subordinateAdded.Name));
                if (subordinate != null)
                {
                    salesman.Subordinates.Remove(subordinate);
                }
                else
                {
                    Console.WriteLine("Subordinate not found");
                }
            }
        }
    }
}
