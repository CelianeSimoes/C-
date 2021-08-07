using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso_C_Sharp
{
    static class Aula10


    {
        public static void MetodoDaAula()
        {

            Console.WriteLine("Conceito de Matriz");
            Console.WriteLine("Faça um programa que leia um número N,e uma matriz quadrade de ordem N contendo números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz.");
            Console.WriteLine("Insira a quantidade de linhas e colunas da matriz"); ;
            int N;
            int[,] A;

            N = int.Parse(Console.ReadLine());
            A = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s1 = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s1[j]);
                }
            }
            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i, i] + "  ");
            }

            Console.WriteLine("Quantidade de numeros negativos");
            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        cont++;

                    }
                }
            }


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
            ;



        }




    }



}






