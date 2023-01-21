using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_04_ALGI_WEB03_exemplo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao = "S";
            while (opcao.Equals("S"))
            {
                Console.WriteLine("Velocidade: ");
                int velocidade = int.Parse(Console.ReadLine());
                if (velocidade > 70)
                {
                    Console.WriteLine($"Velocidade: {velocidade} - Multado!");
                }
                else if (velocidade < 30)
                {
                    Console.WriteLine($"Velocidade: {velocidade} - Aviso!");
                }
                else
                {
                    Console.WriteLine($"Velocidade: {velocidade} - Não multado!");
                }
                Console.WriteLine("Deseja ler outra velocidade? (S/N)");
                opcao = Console.ReadLine();
            }
            Console.WriteLine("Fim do programa!");
            Console.ReadLine();
        }
    }
}
