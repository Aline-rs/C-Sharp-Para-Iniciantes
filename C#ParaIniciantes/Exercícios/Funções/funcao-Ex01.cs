using System;


namespace C_ParaIniciantes.Exercícios.Funções
{
    internal class Ex01Funcao
    {
        public static void PrecoFinal(int valorInicial, string produto)
        {
            int PrecoFinal = valorInicial + (valorInicial/4);

            Console.WriteLine("O valor final do " + produto + " é " + PrecoFinal + ".");
        }
    }
}
