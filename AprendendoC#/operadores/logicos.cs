using System;

class entrada
{
    static void Main()
    //Operadores lógicos trabalham com operandos booleanos e o resultado também será um booleano.
    //Consulta uma tabela verdade ai pra entender melhor esses operadores
    {
        
        bool c1, c2, c3;
        c1 = (10 > 2) && (2 == 2);
        c2 = (10 > 2) && (2 != 2);
        c3 = !((10 > 2) && (2 != 2));

        Console.WriteLine("(10 > 2) && (2 == 2): " + c1); //&&	Operador AND (E)
        Console.WriteLine("(10 > 2) && (2 != 2): "+ c2); //||	Operador OR (OU)
        Console.WriteLine("!(10 > 2) && (2 != 2): "+ c3); //!	Operador NOT (NÃO) ou Negação
        
    }
}