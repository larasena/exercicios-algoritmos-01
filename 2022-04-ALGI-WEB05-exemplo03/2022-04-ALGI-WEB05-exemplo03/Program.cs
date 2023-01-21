using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_04_ALGI_WEB05_exemplo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor 1: ");
            double n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2: ");
            double n2 = int.Parse(Console.ReadLine());
            double maior = Maior(n1, n2);
            Console.WriteLine("Maior = {0:N2}", maior);
            Console.ReadLine();
        }

        static double Maior(double a, double b)
        {
            double m;
            if (a >= b)
            {
                m = a;
            }
            else
            {
                m = b;
            }
            return m;
        }
    }
}
