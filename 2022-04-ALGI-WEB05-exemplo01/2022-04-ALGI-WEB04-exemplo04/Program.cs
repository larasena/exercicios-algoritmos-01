using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_04_ALGI_WEB04_exemplo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um nome: ");
            string n = Console.ReadLine();
            ApresentaMensagem(n);
            Console.WriteLine("Fim do programa");
        }

        // Definição da função
        static void ApresentaMensagem(string nome)
        {
            Console.WriteLine("Olá {0}.", nome);
            Console.ReadLine();
        }
    }
}
