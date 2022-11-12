using Payroll.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Core.Models
{
    public class Employee : EmployeeBase
    {
        public Employee(string id, string name, string surname, decimal baseSalary, EmployeeGender gender, DateTime enrollmentDate, Surcharge surchargePercentage, List<IEmployee> employees = null) :
            base(id, name, surname, baseSalary, gender, enrollmentDate, surchargePercentage, employees) { }


        public override decimal CalculateSalary()
        {
            return Salary + (CalculateSurchargePercentage() / 100) * Salary;
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
