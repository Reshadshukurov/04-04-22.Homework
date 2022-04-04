using _04_04_22.Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_04_22.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            USD usd = new USD(100);
            EUR eur = new EUR(200);
            AZN azn = new AZN(300);
            AZN azn1 = usd;
            Console.WriteLine(azn1.Amount);
            USD usd1 = azn;
            Console.WriteLine(usd1.Amount);
            AZN azn2 = eur;
            Console.WriteLine(azn2.Amount);
            EUR eur1 = azn;
            Console.WriteLine(eur1.Amount);
            EUR eur2 = usd;
            Console.WriteLine(eur2.Amount);
            USD usd2 = eur;
            Console.WriteLine(usd2.Amount);

            Console.ReadLine();

        }
    }
}
