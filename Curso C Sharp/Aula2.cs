using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso_C_Sharp
{
    static class Aula2

    {
        public static void MetodoDaAula()
        {
            Console.WriteLine("executando método da aula 2");
            String frase = Console.ReadLine();

            Console.WriteLine("bom dia " + frase);
            String a = Console.ReadLine();
            String b = Console.ReadLine();
            String c = Console.ReadLine();



            string s = Console.ReadLine();

            string[] v = s.Split(' ');
            string p1 = v[0];
            string p2 = v[1];
            string p3 = v[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Voce digitou");
            Console.WriteLine(n1);
            Console.WriteLine("Entre com seu nome completo: ");
            String fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos voce tem na sua casa: ");
            int bedroons = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            Double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu sobrenome,idade,e altura:");
            String[] vect = Console.ReadLine().Split(' ');
            String LastName = vect[0];
            String Age = vect[1];
            String Height = vect[2];

            Console.WriteLine(fullName);
            Console.WriteLine(bedroons);
            Console.WriteLine(price);
            Console.WriteLine(LastName);
            Console.WriteLine(Age);
            Console.WriteLine(Height);

        }

    }
}
