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

        byte Age { get; }

        EmployeeGender Gender { get; }

        decimal Salary { get; }
        DateTime EnrollmentDate { get; }
    }
}
