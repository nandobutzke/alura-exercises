using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;
            int contMes = 1;

            while(contMes <= 12)
            {
                //0.36% = 0.0036
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contMes + " meses, você terá R$" + valorInvestido);
                contMes++;
            }

            Console.ReadLine();
        }
    }
}
