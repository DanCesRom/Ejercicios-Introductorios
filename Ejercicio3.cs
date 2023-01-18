//Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.

class Detect
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("Elige un numero de 2 digitos: ");
    int x = Convert.ToInt32(Console.ReadLine());
    int number1 =x/10;
    int number2 = x%10;
    Console.WriteLine(number1);
    Console.WriteLine(number2);
    int y = 0;
    

    for (int i = 1; i < (number1 + 1); i++)
    {
      if (number1 % i == 0)
      {
        y++;
      }
    }
    if (y != 2)
    {
      Console.WriteLine(number1+ " No es primo");
    }
    else
    {
      Console.WriteLine(number1+ " Si es primo");
    }
    

    for (int i = 1; i < (number2 + 1); i++)
    {
      if (number2 % i == 0)
      {
        y++;
      }
    }
    if (y != 2)
    {
      Console.WriteLine(number2+ " No es primo");
    }
    else
    {
      Console.WriteLine(number2+ " Si es primo");
    }
    
  }
}