using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso_C_Sharp
{
    static class Aula4
    {
        public static void MetodoDaAula()
        {
            Console.WriteLine("executando método da aula 4");
            Console.WriteLine("Aula 4");
            Console.WriteLine("Utilizando a plataforma URI JUDGE");
            Console.WriteLine("Primeiro exercicio");

            int A, B, X;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            X = A + B;
            Console.WriteLine("X = " + X);

            Console.WriteLine("Segundo exercício");
            Console.WriteLine("Fazer um programa para ler as medidas da base e altura de um retângulo.Em seguida, mostrar o valor da área, perímetro e diagonal deste retangulo, com quatro casas decimais.Onde a Base será nomeada de D em razão da palavra (base) ser uma palavra reservada da linguagem ");
            Console.WriteLine("resolução");
            Double D, altura, area, perimetro, diagonal;
            D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = D * altura;
            perimetro = 2 * (D + altura);
            diagonal = Math.Sqrt(Math.Pow(D, 2.0) + (Math.Pow(altura, 2.0)));
            Console.WriteLine("area =  " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO =  " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL =  " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Terceiro exercício");
            Console.WriteLine("Fazer um programa para ler o nomee idade de duas pessoas. Ao final mostrar uma mensagem com os nomes e a idade média entre essas pessoas,comuma casa decimal.");
            Console.WriteLine("resolução");

            string nome1, nome2;
            int idade1, idade2;
            double media;
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);

            nome2 = vet[1];
            idade2 = int.Parse(vet[1]);
            media = idade1 = idade2 / (2);
            Console.WriteLine("A idade média de" + nome1 + "e" + nome2 + "é de" + media + "anos.");
        }

    }
}
