using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_04_ALGI_WEB04_exemplo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero: ");
            int n = int.Parse(Console.ReadLine());
            for (int k = 1; k <= 10; k++)
            {
                int r = n * k;
                Console.WriteLine("{0} x {1} = {2}", n, k, r);
            }
            Console.ReadLine();
        }
    }
}
