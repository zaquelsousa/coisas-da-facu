using System;

class entrada
{
    static void Main()
    {
        int v1, v2, soma;

        Console.Write("digite um numero: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("digite outro numero: ");
        v2 = int.Parse(Console.ReadLine());

        soma = v1 + v2;

        Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1,v2,soma);
    }
}