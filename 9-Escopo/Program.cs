using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        /*
         * if + TAB duas vezes.
        */

        static void Main(string[] args)
        {
            int idade = 17;
            bool idadeParaEntrar = idade >= 18;

            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "Está acompanhado";

            } else
            {
                mensagemAdicional = "Não está acompanhado";
            }

            if (acompanhado || idadeParaEntrar)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            } else
            {
                Console.WriteLine("Não pode entrar.");
            }

            Console.ReadLine();
           

        }
    }
}
