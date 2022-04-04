using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_04_22.Homework.Models
{
    class EUR
    {
        public double Amount { get; set; }
        public EUR(double Amount)
        {
            this.Amount = Amount;
        }
        public static implicit operator AZN(EUR eur)
        {
            return new AZN(eur.Amount * 1.86);
        }
        public static implicit operator USD(EUR eur)
        {
            return new USD(eur.Amount * 1.09);
        }
    }
}
