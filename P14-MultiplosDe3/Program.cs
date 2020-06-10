using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_MultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primeira Opção
            for(int numero = 3; numero <= 100; numero += 3)
            {
                Console.WriteLine(numero);
            }

            //SegundaOpção
            for (int numero = 3; numero <= 100; numero = numero + 3)
            {
                if(numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
            }


            Console.ReadLine();
        }
    }
}
