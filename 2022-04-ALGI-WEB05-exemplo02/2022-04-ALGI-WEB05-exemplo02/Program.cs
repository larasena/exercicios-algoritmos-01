using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_04_ALGI_WEB05_exemplo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro número: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            int y = int.Parse(Console.ReadLine());
            int resultado = Soma(x, y);
            Console.WriteLine("Soma = {0}", resultado);
            Console.ReadLine();
        }

        static int Soma(int n1, int n2)
        {
            int s = n1 + n2;
            return s;
        } 
        
    
    }
}
