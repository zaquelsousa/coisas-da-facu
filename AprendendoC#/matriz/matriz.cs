using System;

class se
{
    static void Main()
    {

        int linhas, colunas;

        Console.Write("quantas linhas");
        colunas = int.Parse(Console.ReadLine());
        Console.Write("quantas colunas");
        linhas = int.Parse(Console.ReadLine());


        int[,] mat = new int[linhas, colunas];


        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write("Elemento [{0},{1}]", i, j);
                mat[i,j] = int.Parse(Console.ReadLine());

            }
        }
    }
}