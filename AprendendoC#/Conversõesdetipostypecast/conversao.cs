using System;

class conversao
{
    static void Main()
    {
      int vInt = 10;
      short vShort = (short)vInt;//sempre que a conversao nao for implicita de-se fazer a operaçao de type cast

      Console.WriteLine(vShort);
    }
}