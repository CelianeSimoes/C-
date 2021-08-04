using System;
using System.Globalization;

namespace Curso_C_Sharp
{
    static class Program
    {




        static void Main(string[] args)
        {

            Console.WriteLine("Calculo de volume da esfera");
            Console.WriteLine("Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.");

            double R;
            double pi = 3.141592;
            double V;

            Console.WriteLine("Digite o valor do RAIO : ");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            V = (4.0 / 3.0) * pi * (R = Math.Pow(R, 3.0));

            Console.WriteLine("O volume da esfera é = " + V.ToString("F2"));


        }



    }
}



