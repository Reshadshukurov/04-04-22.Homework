using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_04_22.Homework.Models
{
    class USD
    {
        public double Amount { get; set; }
        public USD(double Amount)
        {
            this.Amount = Amount;
        }

        public static implicit operator AZN(USD usd)
        {
            return new AZN(usd.Amount * 1.7);
        }
        public static implicit operator EUR(USD usd)
        {
            return new EUR(usd.Amount / 1.09);
        }
    }
}
