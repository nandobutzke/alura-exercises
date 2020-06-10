using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_DesafioFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            for(int numero = 1; numero <= 10; numero++)
            {
                fatorial = fatorial * numero;
                Console.WriteLine("O fatorial de " + numero + " é " + fatorial);
            }

            Console.ReadLine();
        }
    }
}