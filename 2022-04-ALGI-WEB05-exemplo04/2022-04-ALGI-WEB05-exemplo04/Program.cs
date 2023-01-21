using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_04_ALGI_WEB05_exemplo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número: ");
            int num = int.Parse(Console.ReadLine());
            int soma = Soma1aN(num);
            Console.WriteLine("Soma de 1 a {0} = {1}", num, soma);
            Console.ReadLine();
        }

        static int Soma1aN(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            int soma = 1;
            for (int cont = 2; cont <= n; cont++)
            {
                soma = soma + cont;
            }
            return soma;
        }
    }
}
