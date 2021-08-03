using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso_C_Sharp
{
    static class Aula6


    {
        public static void MetodoDaAula()
        {
            Console.WriteLine("Aula 6");
            Console.WriteLine("Exercicios propostos - continuação");
            Console.WriteLine("Resolução exercicio 1014 URI ONLINE JUDGE");

            Console.WriteLine("Calcule o consumo de combustivel de um veiculo, sendo fornecidas a distancia percorrida e o combustivel gasto");

            int X;
            double Y;
            double consumo;

            Console.WriteLine("Insira a Km rodada");
            X = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o combustivel gasto");
            Y = double.Parse(Console.ReadLine());

            Console.WriteLine("Distancia = " + X + " KM ");

            Console.WriteLine("Combustivel = R$ " +  Y);

            consumo = X / Y;
            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + "  KM / L");


            Console.WriteLine("Resolução exercicio 1005 URI ONLINE JUDGE");
            Console.WriteLine("Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno.A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5(A soma dos pesos portanto é 11).Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.");

            double A;
            double B;
            double media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media >= 5 && media <= 6.9)
            {
                Console.WriteLine("Recuperação");

            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            Console.WriteLine("Resolução exercício 1006 URI ONLINE JUGDE");
            Console.WriteLine("Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.");
            
            double C;
            double D;
            double E;
            double M;
           
            Console.WriteLine("Insira a primeira nota com peso 2");
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira a segunda nota com peso 3");
            D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira a terceira nota com peso 5");
            E = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            M = ((C * 2.0) + (D * 3.0) + (E * 5.0)) / 10;

            Console.WriteLine("MEDIA = " + M.ToString("F2", CultureInfo.InvariantCulture));

            if (media >= 6.0)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media >= 5 && media < 6)
            {
                Console.WriteLine("Recuperação");

            }
            else
            {
                Console.WriteLine("Reprovado");
            }


        }

    }
}
