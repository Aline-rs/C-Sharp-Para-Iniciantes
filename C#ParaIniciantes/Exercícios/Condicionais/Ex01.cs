using System;

namespace C_ParaIniciantes.Exercícios.Condicionais
{
    public class Ex01
    {
        public static void exercicio01()
        {
            int N1;
            int N2;
            int N3;

            Console.Write("Digite o primeiro número: ");
            N1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            N2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            N3 = int.Parse(Console.ReadLine());

            if (N1 < N2 & N1 < N3)
            {
                Console.WriteLine("O primeiro número é o MENOR!");
            }
            else if (N2 < N1 & N2 < N3)
            {
                Console.WriteLine("O segundo número é o MENOR!");
            }
            else if (N3 < N1 & N3 < N2)
            {
                Console.WriteLine("O terceiro número é o MENOR!");
            }
            else if (N1 == N2 & N2 == N3 & N1 == N3)
            {
                Console.WriteLine("Todos os números são iguais!");
            }
            else
            {
                Console.WriteLine("A operação falhou! Tente novamente!");
            }

        }
    }
}
