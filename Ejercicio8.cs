//Leer un número entero de cinco dígitos y determinar si es un número Capicúa.

using System;

class Add
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("Elige el numero de 5 digitos: ");
    int x = Convert.ToInt32(Console.ReadLine());

    int number1 = x/10000;
    int number2 = (x/1000)%10;
    int number4 = (x/10)%10;
    int number5 = (x%10);
    Console.Clear();

    if (number1 == number5)
    {
        if (number2 == number4)
        {
            Console.WriteLine("El Numero es Capicua: " + x);
        }
        else
        {
          Console.WriteLine("El Numero es Capicua: " + x);  
        }
      
    }

    else
    {
      Console.WriteLine("El Numero no es Capicua: " + x);
    }

  }
}
