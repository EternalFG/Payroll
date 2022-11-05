using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Core.Services
{
    public interface ISalaryCalculation : IEmployee
    {
        decimal CalculateSalary();

        uint CalculateSurchargePercentage();
    }
}
