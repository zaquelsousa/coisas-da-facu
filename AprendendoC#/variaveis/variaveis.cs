using System;

class Variaveis
{
    static void Main()
    {
        //e assim que se declara variaveis no C# burao kkkkk foi mal lindao
        //C# é fortemente tipada po, o quer dizer que e necessario que se especifique o tipo da varaiveil.

        int num  = 0; //tipo primitivo para inteiros
        char letra = 'z'; //tipo primitivo para caracteres
        float peso = 85.5f; //tipo primitivo para numeros reais, tem q colcar o f no final do valor.
        string nome = "ze da manga"; //tipo primitivo para strings, a string na real é um array de caracteres, isso msm se vc nao for burro intendeu q é um array de char.

        //da pra declarar vairas variaveis de uma vez desde que sejam de msm tipo, e dps atribuir  valor a elas.
        int n1, n2, vtl;

        n1 = 2;
        n2 = 5;

        vtl = n1 * n2;

        Console.WriteLine(n1 +" x "+ n2+" = "+vtl);
    }
}