using System;
using System.Globalization;

namespace Curso_C_Sharp
{
    static class Program
    {




        static void Main(string[] args)
        {


            Console.WriteLine("Aplicando conceito de matriz");
            Console.WriteLine("Fazer um programa que leia dois números inteiros M e N. em seguida, ler uma matriz de M linhas e N colunas contendo numeros inteiros. Gerar um vetor de modo que cada elemento do vetor seja a soma dos elementos da linha correspondente da matriz.mostrar o vetor gerado");

            int M, N1;
            int[,] mat;
            String[] s = Console.ReadLine().Split(' ');

            M = int.Parse(s[0]);
            N1 = int.Parse(s[1]);
            mat = new int[M, N1];

            for (int a = 0; a < M; a++)
            {
                s = Console.ReadLine().Split(" ");
                for (int b = 0; b < N1; b++)
                {
                    mat[a, b] = int.Parse(s[b]);
                }

            }
            int[] vet = new int[M];
            for (int a = 0; a < M; a++)
            {
                int soma = 0;
                for (int b = 0; b < N1; b++)
                {
                    soma = soma + mat[a, b];
                }
                vet[a] = soma;

            }
            for (int a = 0; a < M; a++)
            {
                Console.WriteLine(vet[a]);
            }
        }
    }
}       
            



