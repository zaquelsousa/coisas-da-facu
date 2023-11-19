/**
1) Faça um programa que leia o valor dos elementos de um vetor de inteiros com 10 posições. Depois que os dados forem fornecidos o programa deverá:

    a.    Mostrar o maior e o menor valor do vetor
    b.    Mostrar quantos números pares e quantos números ímpares existem no vetor
    c.    Mostrar a média aritmética dos valores do vetor
**/

using System;

class exercicio1
{
    static void Main()
    {

        int[] vet = new int[10];

        Console.WriteLine("digite os dez itens do vetor");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("digite o {0}o: ", i + 1);
            vet[i] = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        maiorMenor(vet);
    }

    static void maiorMenor(int[] vetor)
    {
        int maior = int.MinValue;
        int menor = int.MaxValue;
        for (int i = 0; i < 10; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        Console.WriteLine("maior numero : {0}", maior);
        Console.WriteLine("menor numero : {0}", menor);
    }
}
//o resto e paia vou fazer nao fds