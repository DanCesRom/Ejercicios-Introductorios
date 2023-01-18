//Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros.

using System;

class Add
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("Elige un numero de 3 digitos: ");
    int x = Convert.ToInt32(Console.ReadLine());

    int number1 = x/100;
    int number2 = (x/10)%10;
    int number3 = x%10;

    decimal a = Convert.ToDecimal(number1);
    decimal b = Convert.ToDecimal(number2);
    decimal c =Convert.ToDecimal(number3);

    if ((b/a)%1 == 0)
    {
        Console.WriteLine(b + " Es multiplo de " + a);
    }
    if ((c/a)%1 == 0)
    {
        Console.WriteLine(c + " Es multiplo de " + a);
    }


    if ((a/b)%1 == 0)
    {
        Console.WriteLine(a + " Es multiplo de " + b);
    }
    if ((c/b)%1 == 0)
    {
        Console.WriteLine(c + " Es multiplo de " + b);
    }


    if ((a/c)%1 == 0)
    {
        Console.WriteLine(a + " Es multiplo de " + c);
    }
    if ((b/c)%1 == 0)
    {
        Console.WriteLine(b + " Es multiplo de " + c);
    }
  }
}
