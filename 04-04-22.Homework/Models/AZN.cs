using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_04_22.Homework.Models
{
    class AZN
    {
        public double Amount { get; set; }
        public AZN(double Amount)
        {
            this.Amount = Amount;
        }
        public static implicit operator USD(AZN azn)
        {
            return new AZN(azn.Amount / 1.7);
        }
        public static implicit operator EUR(AZN azn)
        {
            return new AZN(azn.Amount / 1.86);
        }
    }
}
 