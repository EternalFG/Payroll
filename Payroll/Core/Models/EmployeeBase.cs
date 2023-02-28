using LiteDB;
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
        [BsonId] public string Id { get; }

        public User User { get; set; } = new User();
        public EmployeeBase(string id,string name, string surname, decimal salary, EmployeeGender gender, DateTime enrollmentDate, Surcharge surchargePercentage, List<IEmployee> subordinates = null)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Salary = salary;
            Subordinates = subordinates;
            Gender = gender;
            EnrollmentDate = enrollmentDate;
            SurchargePercentage = surchargePercentage;
        }

        public EmployeeBase() { }
        
        public string Name { get; }
        public string Surname { get; }
        public decimal Salary { get; }
        public EmployeeGender Gender { get; }
        public DateTime EnrollmentDate { get; }
        public Surcharge SurchargePercentage { get; }
        public List<IEmployee> Subordinates { get; set; }
        public abstract decimal CalculateSalary();
        public abstract uint CalculateSurchargePercentage();
    }
}
