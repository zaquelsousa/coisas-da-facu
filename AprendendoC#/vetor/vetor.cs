using System;

class Vetor
{
    static void Main()
    {
        
        int N;
        Console.Write("quantos numeros vc vai digitar? ");
        N = int.Parse(Console.ReadLine());

        double[] vet = new double[N]; //essa que é a sintaxe para declarar um vetor

        for(int i=0; i < N; i++){
            Console.Write("Digite um numero: ");
            vet[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("numeros digitados");
        for(int i = 0; i < N; i++){
            Console.Write("\n"+vet[i]);
        }
    }
}