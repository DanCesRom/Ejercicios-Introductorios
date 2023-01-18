//Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.

using System;

class Add
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("Elige un numero de 2 digitos: ");
    
    int number = Convert.ToInt32(Console.ReadLine());
    int x = number/10;
    int y = number%10;

    int suma = x + y;
    Console.WriteLine("La suma de " + x  + " y " + y + " es: " + suma);

  }
}
