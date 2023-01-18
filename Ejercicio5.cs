// Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito.

using System;

class Add
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("Elige el numero de 3 digitos: ");
    int x = Convert.ToInt32(Console.ReadLine());

    int number1 = x/100;
    int number2 = (x/10)%10;
    int number3 = (x%10);

    Console.Clear();

    Console.WriteLine(number1);
    Console.WriteLine(number2);
    Console.WriteLine(number3);

    if (number1>=number2)
    {
        if (number1>number3)
        {
            Console.WriteLine("El Mayor esta en la 1era posicion");
        }
        else
        {
            Console.WriteLine("El Mayor esta en la 3era posicion");
        }
    }
    else if (number2>=number1)
    {
        if (number2>number3)
        {
            Console.WriteLine("El Mayor esta en la 2era posicion");
        }
        else
    {
        Console.WriteLine("El Mayor esta en la 3era posicion");
    }

    }   
   
  }
}
