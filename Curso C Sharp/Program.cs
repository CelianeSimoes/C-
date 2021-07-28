using System;
using System.Globalization;

namespace Curso_C_Sharp
{
    class Program
    {
        private static object vet;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Double x = 15.237;
            Console.WriteLine(x);
            Double y = 12.476;
            Console.WriteLine(y);


            Console.WriteLine(x * y);


            Console.WriteLine("Aula17");



            String frase = Console.ReadLine();

            Console.WriteLine("bom dia " + frase);
            String a = Console.ReadLine();
            String b = Console.ReadLine();
            String c = Console.ReadLine();

           

            string s = Console.ReadLine();

            string [] v = s.Split(' ');
            string p1 = v[0];
            string p2 = v[1];
            string p3 = v[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            int n1 = int.Parse (Console.ReadLine());
           Console.WriteLine ("Voce digitou");
            Console.WriteLine(n1);

            Console.WriteLine("Entre com seu nome completo: ");
            String fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos voce tem na sua casa: ");
            int bedroons = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            Double price = double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
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
