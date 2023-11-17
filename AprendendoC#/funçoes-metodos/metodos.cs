using System;

class se
{
    static void Main()
    {

        int res = 0;

        res = soma(10,20);

        Console.WriteLine(res);

    }

    static int soma(int n1, int n2){
        int res = n1 + n2;
        return res;

        //como esse metodo retorna um valor deve se colocar antes do nome dele o seu tipo, assim que o chamar vai receber aquele tipo de dado
    }
}