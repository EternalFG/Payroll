using LiteDB;
using Payroll.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Core.Models
{
    public class User 
    {
        [BsonId] public string UserName { get; set; }
        public string Password { get; set; }

        public bool Employee { get; set; }

        public decimal Salary { get; set; }

        public string Gender { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}
