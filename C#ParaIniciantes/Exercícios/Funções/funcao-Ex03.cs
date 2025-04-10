using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ParaIniciantes.Exercícios.Funções
{
    internal class Ex03Funcao
    {
        public static void Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            double area = (baseTriangulo * alturaTriangulo)/2;

            Console.WriteLine("A área do triangulo é " + area + "m");
        }
    }
}
