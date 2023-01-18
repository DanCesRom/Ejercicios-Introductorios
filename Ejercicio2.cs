//Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.

class Detect
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("Elige un numero de 2 digitos: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int x = 0;
    if (number<0)
    {
        Console.WriteLine("El numero " + (number) + " es negativo");
    
    }
    else
    {   
        for (int i = 1; i < (number + 1); i++)
        {
          if (number % i == 0)
          {
            x++;
          }
        }
        if (x != 2)
        {
          Console.WriteLine(number+ " No es primo");
        }
        else
        {
          Console.WriteLine(number+ " Si es primo");
        }
    }
  }
}