using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso_C_Sharp
{
    static class Aula8


    {
        public static void MetodoDaAula()
        {

            Console.WriteLine("Resolução exercicio proposto 1013");
            Console.WriteLine("Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”.");

            int x;
            int y;
            int z;
            int maiorXY;
            int maior;

            string[] valores = Console.ReadLine().Split(' ');
            Console.WriteLine("Insira os 3 valores para que o sistema lhe informe o maior");
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
            z = int.Parse(valores[2]);

            maiorXY = (x + y + Math.Abs(x - y)) / 2;

            maior = (maiorXY + z + Math.Abs(maiorXY - z)) / 2;

            Console.WriteLine(maior + " eh o maior");

            Console.WriteLine("Resolução exercício 1015");
            Console.WriteLine("Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula");


            double x1;
            double x2;
            double y1;
            double y2;

            Console.WriteLine("Insira o km inicial e km final do primeiro ponto");
            string[] valores2 = Console.ReadLine().Split(" ");

            x1 = double.Parse(valores2[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valores2[1], CultureInfo.InvariantCulture);

            valores2 = Console.ReadLine().Split(" ");
            x2 = double.Parse(valores2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valores2[1], CultureInfo.InvariantCulture);



            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Resolução exercício 1018");
            Console.WriteLine("Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas são de 200, 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.");
            int N;
            int quociente;
            int resto;
            int nota;

            Console.WriteLine("Insira o valor a ser calculado");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N;

            nota = 200;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;


            nota = 50;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            Console.WriteLine(resto + " nota(s) de R$ 1,00");

            Console.WriteLine("Resolução exercício 1020 URI JUDGE");
            Console.WriteLine("Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias");
            Console.WriteLine("Insira um valor para calculo e coversão de anos, meses e dias");

            int A;
            int anos;
            int meses;
            int dias;
            int resto1;

            A = int.Parse(Console.ReadLine());

            anos = A / 365;
            resto1 = A % 365;
            meses = resto1 / 30;
            dias = resto1 % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");


            Console.WriteLine("Resolução exercício 1035 URI JUDGE");
            Console.WriteLine("Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A for par escrever a mensagem VALORES ACEITOS, senão escrever VALORES NÃO ACEITOS.");
            string[] valores1 = Console.ReadLine().Split(' ');


            int A1 = int.Parse(valores1[0]);
            int B = int.Parse(valores1[1]);
            int C = int.Parse(valores1[2]);
            int D = int.Parse(valores1[3]);

            if (B > C && D > A1 && C + D > A1 + B && C > 0 && D > 0 && A1 % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

            Console.WriteLine("Resolução exercício 1038 URI JUDGE");
            Console.WriteLine("Escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.");

            string[] valores3 = Console.ReadLine().Split(' ');
            int código = int.Parse(valores3[0]);
            int quantidade = int.Parse(valores3[1]);
            double total;

            if (código == 1)
            {
                total = quantidade * 4.0;

            }
            else if (código == 2)
            {
                total = quantidade * 4.5;
            }
            else if (código == 3)
            {
                total = quantidade * 5.0;
            }
            else if (código == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}   





