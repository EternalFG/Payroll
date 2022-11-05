using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Core.Models
{
    public class Surcharge
    {
        public uint IncreaseSurcharge;
        public uint MaxSurcharge;

        public Surcharge(uint increaseSurcharge, uint maxSurcharge)
        {
            IncreaseSurcharge = increaseSurcharge;
            MaxSurcharge = maxSurcharge;
        }
    }
}
