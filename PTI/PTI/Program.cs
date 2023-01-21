using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeticao;
            Console.WriteLine("Deseja realizar novo cálculo? (s) ou (n)?");
            repeticao = Console.ReadLine();
            while (repeticao == "s" || repeticao == "S")
            {
                double gasolina, alcool, resultado;
                Console.WriteLine("Insira o valor da gasolina:");
                gasolina = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira o valor do alcool:");
                alcool = Convert.ToDouble(Console.ReadLine());
                resultado = (alcool / gasolina);
                if (resultado > 0.7)
                {
                    Console.WriteLine("É mais vantajoso comprar a gasolina!");
                }
                else if (resultado < 0.7)
                {
                    Console.WriteLine("É mais vantajoso comprar o álcool");
                }
                else
                {
                    Console.WriteLine("Tanto faz abastecer com um ou outro");
                }
                Console.WriteLine("Deseja realizar novo cálculo? (s) ou (n)?");
                repeticao = Console.ReadLine();
            }
            if (repeticao == "n" || repeticao == "N")
            {
                Console.WriteLine("Finalizado");
                Console.ReadLine();
            }
        }
    }
}
