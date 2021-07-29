using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso_C_Sharp
{
    static class Aula3

    {
        public static void MetodoDaAula()
        {
            Console.WriteLine("executando método da aula 3");
            Console.WriteLine("Aula 3");
            Console.WriteLine("Funções matematicas");
            double X = (49);
            Double Y = (36);
            Double Z = (200);
            double A, B, D;
            A = Math.Sqrt(X);
            B = Math.Pow(X,Y);
            D = Math.Abs(X + Y + Z);
            Console.WriteLine("O resultado da raiz quadrada de 49 é " + (A));
            Console.WriteLine("O resultado de 49 elevado a 36ª potencia é " + (B));
            Console.WriteLine(D);
            Console.WriteLine("A raiz quadrada de " + (X) + "e igual" + (A));
            Console.WriteLine("Problema matemático");
            Console.Write("Calcule a área e o valor do terreno, com base nas informações: Largura 10 metros, Comprimento 30 metros e valor do metro quadrado R$2.000,00");
            Console.WriteLine("RESOLUÇÃO");
            Console.WriteLine("Área = largura x comprimento");
            Double Largura, Comprimento, Area, PreçoMetroQuadrado,preço;
            Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            PreçoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Area = Largura * Comprimento;
            Console.WriteLine(Area);
            preço = Area * PreçoMetroQuadrado;
            Console.WriteLine(preço);
            Console.WriteLine("Area = " + Area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço = " + preço.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
