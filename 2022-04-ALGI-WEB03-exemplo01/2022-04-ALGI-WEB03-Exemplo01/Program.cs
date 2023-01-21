using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_04_ALGI_WEB03_Exemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Velocidade: ");
            int velocidade = int.Parse(Console.ReadLine());
            if (velocidade >= 70)
            {
                Console.WriteLine("Multado!");
            }
            Console.WriteLine("Fim do programa!");
            Console.ReadLine();
        }
    }
}
