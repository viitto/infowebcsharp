using System;

class MainClass
{
  public static void Main (string[] args)
 {
   double b, h, a;
   Console.WriteLine("digite a base do triangulo");
   b = double.Parse(Console.ReadLine());
   Console.WriteLine("digite a altura do triangulo");
   h = double.Parse(Console.ReadLine());
   a = b * h / 2;
  Console.WriteLine($"area = {a:0.00}");
// a = variavel 0.00 formatação
 }
}
