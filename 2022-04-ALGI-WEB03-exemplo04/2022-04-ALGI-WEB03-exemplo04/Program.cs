using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_04_ALGI_WEB03_exemplo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            while (cont <= 10)
            {
                Console.WriteLine(cont);
                cont = cont + 1;
            }
            Console.WriteLine("Fim do programa!");
            Console.ReadLine();
        }
    }
}
