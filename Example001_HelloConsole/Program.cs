using System;

namespace My3
{
     class Program
     {
          static void Main(string[] args)
          {
               double x = 0.5;
               int stepen = 4;
               Console.WriteLine("0.5^4 = " + Math.Pow(x, stepen));
               Console.WriteLine("5^4 = " + Math.Pow(5, 4));
               Console.WriteLine("-5^4 = " + Math.Pow(-5, 4));
               Console.WriteLine("-5^(-4) = " + Math.Pow(-5, -4));
               Console.ReadKey();
          }
     }
}