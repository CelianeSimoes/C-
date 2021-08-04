using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso_C_Sharp
{
    static class Aula7


    {
        public static void MetodoDaAula()
        {
            ResolucaoExerciciosJudge.MetodoDaAula();

            Console.WriteLine("Calculo salário com comissão e bonificação");
            Console.WriteLine("Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.");
            // Adicionada a condição IF Else, para incluir a bonificação por vendas acima do valor de 1.000,00
            string nome;
            double SalarioFixo;
            double TotalVenda;
            double SalarioTotal;

            Console.WriteLine("Insira o nome do vendedor");
            nome = Console.ReadLine();

            Console.WriteLine("Insira o valor do salário fixo");
            SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o total de venda realizadas");
            TotalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Salário total mês");
            SalarioTotal = TotalVenda * 15.0 / 100 + SalarioFixo;
            Console.WriteLine("Total = R$ " + SalarioTotal.ToString("F2", CultureInfo.InvariantCulture));

            if (TotalVenda > 1000.00)
            {
                Console.WriteLine("Salario com bonificação R$  " + (SalarioTotal + 200));
            }
            else
            {

                Console.WriteLine("Salario sem bonificação R$  " + SalarioTotal);
            }


            Console.WriteLine("Resolução problema 1078 - URI JUDGE");
            Console.WriteLine("Leia 1 valor inteiro N (2 < N < 1000). A seguir, mostre a tabuada de N");

            int N;
            N = int.Parse(Console.ReadLine());

            for(int i=1;i<=10; i++)
            {
                int resultado = i * N;
                Console.WriteLine(i + " x " + N + " = " + resultado);
            }

            Console.WriteLine("Aplicando o  conhecimento da estrutura  - FAÇA ENQUANTO"); 
            Console.WriteLine("Fazer um programa para ler a temperatura em Celsius e mostrar o equivalente em Fahrenheit. Perguntar se o usuário deseja repetir (S/N). Caso o usuário digite S, repetir o programa" );


            double C;
            double F;
            char repetir;

            do
            {
                Console.WriteLine("Digite uma temperatura em Celsius para conversão");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir (s/n)");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');


        }

    }
}
