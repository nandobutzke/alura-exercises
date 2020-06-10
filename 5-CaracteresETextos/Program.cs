using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            char primeiraLetra = 'a';

            primeiraLetra = (char)78;
            Console.WriteLine("Nando começa com a letra " + "'" + primeiraLetra + "'");

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine("Letra seguinte: " + primeiraLetra);

            primeiraLetra = 'a';

            String frase = "Eu amo amendoim, essa palavra começa com a letra " + "'" + primeiraLetra + "'";
            Console.WriteLine(frase);

            String titulo = "Alura cursos de tecnologia" + 2020;
            String cursosProgramacao = @"Os cursos disponíveis são:

- .NET

- JAVA

- HTML5 E CSS3";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
