using System;

class Add
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("Elige el 1er numero: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.Clear();
    Console.WriteLine("Elige el 2ndo numero: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int diferencia = (number1 - number2);
    int abs;

    if (diferencia<0)
    {
      abs = -diferencia;
    }
    else
    {
      abs = diferencia;
    }

    if (number1>number2)
    {
     diferencia = number2;
    }
    else
    {
      diferencia = number1;
    }

    if (abs>=10)
    {
      Console.Clear();
      Console.WriteLine("La diferencia es is igual o mayor a 10");
      for (int i = diferencia; i < (diferencia+abs-1); i++)
      {
        Console.WriteLine(i+1);
      }
    }
    
  }
}
