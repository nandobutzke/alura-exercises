using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CreatingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 2 - Criando Variáveis");

            int idade = (3 * 2) * 3;

            double valor = 2200.50;

            Console.WriteLine("Fernando tem " + idade + " anos");
            Console.WriteLine("e ganha R$ " + valor + " por mês.");
            
            Console.WriteLine("Tecle enter para finalizar a execução");
            Console.ReadLine();
        }
    }
}
