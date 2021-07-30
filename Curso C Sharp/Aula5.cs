using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso_C_Sharp
{
    static class Aula5

    {
        public static void MetodoDaAula()
        {
            Console.WriteLine("Aula 5");
            Console.WriteLine("Exercicios propostos - continuação");
            Console.WriteLine("Resolução exercicio 1002 URI ONLINE JUDGE");
            Console.WriteLine("Calcule a área de uma circunferência");
            double R, A, pi = 3.14159;
            R = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = pi * R * R;
            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Resolução Exercicio 1003 - URI ONLINE JUDGE");
            Console.WriteLine("Realize a soma de dois números inteiros e imprima o resultado");
            int C, B, Soma;
            C = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            Soma = C + B;
            Console.WriteLine("SOMA = " + Soma);

            Console.WriteLine("Resolução exercicio 1004 URI ONLINE JUDGE");
            Console.WriteLine("Calcule o produto entre 2 valores");

            int D, E, Prod;
            D = int.Parse(Console.ReadLine());
            E = int.Parse(Console.ReadLine());
            Prod = D * E;
            Console.WriteLine("PRODUTO = " + Prod);


        }

    }
}
