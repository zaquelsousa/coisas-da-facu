using System;

class se
{
    static void Main()
    {
        int nota = 59;
        string res = "reprovado";

        if (nota < 60)
        {
            //aqui vc coloca a logica que deseja nesse desvio condicional
            Console.WriteLine(res);
        }
        else
        {
            Console.WriteLine(res="aprovado");
        }
    }
}