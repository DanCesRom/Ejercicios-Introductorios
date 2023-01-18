//Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.

using System;

class Add
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("Elige el 1er digito: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Clear();
    Console.WriteLine("Elige el 2ndo digits: ");
    int y = Convert.ToInt32(Console.ReadLine());

    int big = Math.Max(x,y);

    Console.Clear();
    Console.WriteLine("Elige el 3er digito: ");
    int z = Convert.ToInt32(Console.ReadLine());
    
    big = Math.Max(big,z);

    Console.Clear();
    Console.WriteLine("El numero mas grande es: " + big);
   
  }
}
