using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeNando = 16;
            int quantidadePessoas = 1;

            if (idadeNando >= 18)
            {
                Console.WriteLine("Nando pode entrar na festa.");
            }
            else
            {
                if (quantidadePessoas > 0)
                {
                    Console.WriteLine("Nando não possui 18 anos, mas está acompanhado, então pode entrar.");
                }
                else
                {
                    Console.WriteLine("Nando não pode entrar na festa.");
                }
            }

            Console.ReadLine();
        }
    }
}
