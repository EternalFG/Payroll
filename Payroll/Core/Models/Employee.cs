using Payroll.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Core.Models
{
    public class Employee : ISalaryCalculation
    {
        private string _name;
        private string _surname;
        private byte _age;
        private EmployeeGender _gender;
        private decimal _salary;
        private DateTime _enrollmentDate;
        private Surcharge _surchargePercentage = new Surcharge(3, 30);

        public Employee(string name, string surname, byte age, EmployeeGender gender, decimal baseSalary, DateTime enrollmentDate)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _gender = gender;
            _salary = baseSalary;
            _enrollmentDate = enrollmentDate;
        }

        public string Name => _name;
        public string Surname => _surname;
        public byte Age => _age;
        public EmployeeGender Gender => _gender;
        public decimal Salary => CalculateSalary();
        public DateTime EnrollmentDate => _enrollmentDate;

        public decimal CalculateSalary()
        {
            return _salary + (CalculateSurchargePercentage()/100)*_salary;
        }

        public uint CalculateSurchargePercentage()
        {
            if ((DateTime.Now.Year - _enrollmentDate.Year)*_surchargePercentage.IncreaseSurcharge >= _surchargePercentage.MaxSurcharge)
            {
                return _surchargePercentage.MaxSurcharge;
            }
            else
            {
                return (uint)((DateTime.Now.Year - _enrollmentDate.Year) * _surchargePercentage.IncreaseSurcharge);
            }
        }

        public Employee() { }
    }
}
