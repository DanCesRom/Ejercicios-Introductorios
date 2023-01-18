//Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.

using System;

class Add
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("Elige el 1er numero: ");
    decimal x = Convert.ToDecimal(Console.ReadLine());

    Console.Clear();
    Console.WriteLine("Elige el 2ndo numero: ");
    decimal y = Convert.ToDecimal(Console.ReadLine());

    decimal suma = x + y;
    Console.Clear();
    Console.WriteLine("La suma de " + x  + " y " + y + " es: " + suma);
    
    if ((suma/2)%1 == 0)
    {
      Console.WriteLine("La suma de los numeros es par: " + x + " + " +y + " = "+ suma);
    }
    else
    {
      Console.WriteLine("La suma de los numeros no es par: " + x + " + " + y + " = "+ + suma);
    }
  }
}
