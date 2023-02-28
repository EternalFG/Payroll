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

        public Manager(string id, string name, string surname, decimal baseSalary, EmployeeGender gender, DateTime enrollmentDate, Surcharge surchargePercentage, List<IEmployee> employees = null) :
            base(id, name, surname, baseSalary, gender, enrollmentDate, surchargePercentage, employees) { }



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

        public Manager() { }
    }
}
