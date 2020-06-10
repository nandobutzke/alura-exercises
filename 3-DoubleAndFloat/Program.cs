using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3_DoubleAndFloat
{
    class Program
    {

        /*
         * Deve haver um sufixo "f" após o valor da varável do tipo float ter sido declarada;
         * A divisão entre dois números inteiros resultará em um número inteiro, quando há um double na divisão,
         o resultado será de acordo com o tipo da variável declarada.
        */



        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3: criando varáveis com ponto flutuante");

            float valor1 = 10.20f;
            double valor2 = 17.10;

            double divisao;
            divisao = 15 / 2.0;
            
            Console.WriteLine("Resultado float: " + valor1);
            Console.WriteLine("Resultado double: " + valor2);
            Console.WriteLine("O resultado da divisão será: " + divisao);
            Console.ReadLine();
        }
    }
}
