using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_04_ALGI_WEB02_Exemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;
            Console.WriteLine("Digite um numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
