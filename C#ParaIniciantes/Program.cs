using System;
using C_ParaIniciantes.Exercícios.Condicionais;


namespace C_ParaIniciantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // ====== Tipos de variaveis ======

            // Int = Serve para armazenar números inteiros (-123 ou 1234)
            // Float/Double = Números decimais. Para números float é necessário colocar um f no final.
            // Bool = Boleano (Verdadeiro ou Falso)
            // String = Identificado por "" (Texto)
            // Char = Caractere identificado por ''

            int segundaGuerreMundial = 1942;
            string cor_favorita = "Vermelho";
            float velocidadeF1 = 294.48f;
            bool segundaGuerreMundialAconteceu = true;

            Console.WriteLine(segundaGuerreMundial);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerreMundialAconteceu);

            velocidadeF1 = 348.29F; // Após criar a variavel é possivel alterar seu valor apenas chamando a variavel.
            cor_favorita = "Roxo";


            // ====== Regras para criar variáveis ======

            // A-Z
            // 0-9 -> Número no inicio não é permitido
            // @ $ . -> Caracteres especiais não são permitidos
            // using -> Palavras reservadas do sistema não podem ser utilizadas
            // _ -> É permitido

            var meuTexto = "Helo World";
            var meuNome = "Aline Rosa";

            Console.WriteLine(meuTexto);
            Console.Write(meuNome);

            

            // constante é um tipo de variavel que impede a alteração do valor no decorrer do projeto.

            const float PI = 3.145565656F;

            PI = 3.12; // Valor não pode ser alterado

            

            // ====== Capturando a entrada do usuário ======

            string nome = "";
            Console.WriteLine("Escreva seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);

            

            // ====== Operadores Aritméticos ======

            // 6 / 2 => 3 //int
            // 5 / 2 => 2.5 // decimal/float

            int numeroQualquer = 20 + 20 - 80;
            int numeroMulti = 10 * 90;
            int numeroDiv = 90 / 10;

            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroMulti);
            Console.WriteLine(numeroDiv);


            // ====== Condicionais ======

            Console.WriteLine("Qual seu time favorito?");
            string timeFavorito = Console.ReadLine();

            if (timeFavorito == "Cruzeiro")
            {
                Console.WriteLine("Você tem bom gosto!");
            }
            else
            {
                Console.WriteLine("Procure ajuda!");
            }
            */
            //Ex01.exercicio01();
            //Ex02.exercicio02();
            Ex03.exercicio03();

            Console.ReadLine();

            


        }
    }
}
