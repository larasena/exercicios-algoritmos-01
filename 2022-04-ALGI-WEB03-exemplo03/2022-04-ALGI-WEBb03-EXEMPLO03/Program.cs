using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_04_ALGI_WEBb03_EXEMPLO03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura;
            Console.WriteLine("Insira seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira sua altura em m: ");
            altura = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);

            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }
            Console.ReadLine();
        }
    }
}
