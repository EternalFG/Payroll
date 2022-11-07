using Payroll.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Core.Models
{
    public abstract class EmployeeBase : ISalaryCalculation
    {
        protected EmployeeBase(string name, string surname, byte age, EmployeeGender gender, decimal salary, DateTime enrollmentDate, Surcharge surchargePercentage, List<IEmployee> subordinates = null)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            Salary = salary;
            EnrollmentDate = enrollmentDate;
            SurchargePercentage = surchargePercentage;
            Subordinates = subordinates;
        }

        public string Name { get; }

        public string Surname { get; }
        public byte Age { get; }

        public EmployeeGender Gender { get; }

        public decimal Salary { get; }

        public DateTime EnrollmentDate { get; }

        public Surcharge SurchargePercentage { get; }
        public List<IEmployee> Subordinates { get; }

        public abstract decimal CalculateSalary();

        public abstract uint CalculateSurchargePercentage();
    }
}
