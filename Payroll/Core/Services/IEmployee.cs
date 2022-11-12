using Payroll.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Core.Services
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        decimal Salary { get; }
        EmployeeGender Gender { get; }

        DateTime EnrollmentDate { get; }
    }
}
