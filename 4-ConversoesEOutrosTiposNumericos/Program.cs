using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {

        /*
         * A operação de conversão de double para inteiro e vice-versa, é denominada de "type casting". Ex: (double), (int);
         * Long: tipo de variável que consegue armazenar valores muito maiores, com limite de 64 bits;
         * Short: ocupa 16 bits na memória;
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            int salarioInteiro = (int) salario;

            long idadeDoUniverso = 13000000000;

            short quantidadeProdutos = 15000;

            Console.WriteLine("A conversão de Double para Inteiro será de " + salarioInteiro + " reais.");

            Console.WriteLine("A idade do universo é de " + idadeDoUniverso + " de anos.");
            Console.WriteLine("A quantidade de produtos é de " + quantidadeProdutos + ".");

            
            Console.ReadLine();
        }
    }
}
