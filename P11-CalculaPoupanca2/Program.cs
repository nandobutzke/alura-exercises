using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000.0;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, o valor será de R$ " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
