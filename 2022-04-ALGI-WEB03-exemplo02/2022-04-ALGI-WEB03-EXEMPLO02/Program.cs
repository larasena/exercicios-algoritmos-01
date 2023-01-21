using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_04_ALGI_WEB03_EXEMPLO02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu salário: ");
            double salario = double.Parse(Console.ReadLine());
            double novoSalario;
            if (salario <= 300)
            {
                novoSalario = salario * 1.15;
            }
            else
            {
                novoSalario = salario * 1.075;
            }
            Console.WriteLine("Novo salário = R$ {0:N2}", novoSalario);
            Console.ReadLine();
        }
    }
}
