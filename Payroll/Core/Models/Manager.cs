using Payroll.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Core.Models
{
    public class Manager : EmployeeBase
    {

        public Manager(string name, string surname, byte age, EmployeeGender gender, decimal baseSalary, DateTime enrollmentDate) :
            base(name, surname, age, gender, baseSalary, enrollmentDate, new Surcharge(5, 40), new List<IEmployee>()) { }


        public override decimal CalculateSalary()
        {
            decimal subordinatesSurcharge = 0;
            foreach (var subordinate in Subordinates)
            {
                subordinatesSurcharge += subordinate.Salary * (decimal)0.05;
            }
            return Salary + (CalculateSurchargePercentage() / 100) * Salary + subordinatesSurcharge;
        }


        public override uint CalculateSurchargePercentage()
        {
            if ((DateTime.Now.Year - EnrollmentDate.Year) * SurchargePercentage.IncreaseSurcharge >= SurchargePercentage.MaxSurcharge)
            {
                return SurchargePercentage.MaxSurcharge;
            }
            else
            {
                return (uint)((DateTime.Now.Year - EnrollmentDate.Year) * SurchargePercentage.IncreaseSurcharge);
            }
        }
    }
}
