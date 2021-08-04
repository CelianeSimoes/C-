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

            Console.WriteLine("Resolução exercicio 1019 URI ONLINE JUDGE");
            Console.WriteLine("Conversão de tempo");

            int N, horas, resto, minutos, segundos;
            N = int.Parse(Console.ReadLine());
            horas = N / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;
            Console.WriteLine("horas" + horas + ":" + minutos + "minutos" + segundos + "segundos");

            Console.WriteLine("Resolução exercicio 1007 URI ONLINE JUDGE");
            Console.WriteLine("Diferença");

            int F, G, H, I, DIF;
            F = int.Parse(Console.ReadLine());
            G = int.Parse(Console.ReadLine());
            H = int.Parse(Console.ReadLine());
            I = int.Parse(Console.ReadLine());
            DIF = F * G - H * I;
            Console.WriteLine("DIFERENÇA = " + DIF);
            Console.WriteLine("Resolução exercicio 1008 URI ONLINE JUDGE");
            Console.WriteLine("Cálculo de salário por hora trabalhada");


            int Numero;
            int Horas;
            double Salario;
            double ValorHora;

            Console.WriteLine("Digite o número");
            Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de horas");
            Horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da hora trabalhada");
            ValorHora = double.Parse(Console.ReadLine());

            Salario = ValorHora * Horas;

            Console.WriteLine("NUMBER" + Numero);
            Console.WriteLine("SALARY = U$" + Salario.ToString("F2", CultureInfo.InvariantCulture));


        }

    }
}
