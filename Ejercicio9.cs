// Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo.

using System;

class Add
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("Elige el numero de 4 digitos: ");
    int x = Convert.ToInt32(Console.ReadLine());

    int number1 = x/1000;
    int number2 = (x/100)%10;
    int number3 = (x/10)%10;
    int number4 = (x%10);
    Console.Clear();
    
    if (number2 == number3)
    {
      Console.WriteLine("El segundo digito es igual al penultimo: " + x);
    }
    else
    {
      Console.WriteLine("El segundo digito no es igual al penultimo: " + x);
    }

  }
}
