using System;



struct Car{
    public string nome;
    public string marca;
}
class prodocarai
{
    static void Main()
    {
        int[,] mat = new int[3, 5];
        int soma = 0; // Inicializa a variável com zero.

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                 Console.WriteLine("porra");
                soma += mat[j,i];
            }
        }
        Console.WriteLine("soma {0}", soma);
    }
}