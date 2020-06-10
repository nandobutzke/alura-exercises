using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primeira forma
            for(int linha = 1; linha <= 12; linha++)
            {
                for(int coluna = 1; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Segunda forma: Usando o break
            for (int linha = 1; linha <= 12; linha++)
            {
                for (int coluna = 1; coluna <= 12; coluna++)
                {
                    Console.Write("*");
                    if (coluna >= linha)            //Nesse caso o contador coluna, tem que ser maior ou igual ao contador linha
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
