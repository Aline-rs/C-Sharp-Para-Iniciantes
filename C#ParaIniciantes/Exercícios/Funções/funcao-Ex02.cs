using System;

namespace C_ParaIniciantes.Exercícios.Funções
{
    internal class Ex02Funcao
    {
        public static void Pizza(double raio)
        {
            double area = 3.14 * (raio * raio);

            Console.WriteLine("A área da pizza deve ser aproximadamente " + area + "cm.");

            //A = π r²
        }
    }
}
