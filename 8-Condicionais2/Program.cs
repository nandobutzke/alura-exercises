using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {

        /*
         * No C#, o correto é bool, ao invés de boolean.
        */

        static void Main(string[] args)
        {
            bool idadeParaEntrar = false;
            bool acompanhado = true;

            if(idadeParaEntrar || acompanhado)
            {
                Console.WriteLine("Pode entrar.");
            } else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
