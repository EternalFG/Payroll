using Payroll.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Core.Models
{
    public class Manager : ISalaryCalculation
    {
        private string _name;
        private string _surname;
        private byte _age;
        private EmployeeGender _gender;
        private decimal _salary;
        private DateTime _enrollmentDate;
        private Surcharge _surchargePercentage = new Surcharge(5, 40);
        public List<Employee> Subordinates { get; } = new List<Employee>();

        public Manager(string name, string surname, byte age, EmployeeGender gender, decimal salary, DateTime enrollmentDate)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _gender = gender;
            _salary = salary;
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
            decimal subordinatesSurcharge = 0;
            foreach (var subordinate in Subordinates)
            {
                subordinatesSurcharge += subordinate.CalculateSalary() * (decimal)0.05;
            }
            return _salary + (CalculateSurchargePercentage() / 100) * _salary + subordinatesSurcharge;
        }


        public uint CalculateSurchargePercentage()
        {
            if ((DateTime.Now.Year - _enrollmentDate.Year) * _surchargePercentage.IncreaseSurcharge >= _surchargePercentage.MaxSurcharge)
            {
                return _surchargePercentage.MaxSurcharge;
            }
            else
            {
                return (uint)((DateTime.Now.Year - _enrollmentDate.Year) * _surchargePercentage.IncreaseSurcharge);
            }
        }
    }
}
