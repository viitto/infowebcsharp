using System;

class MainClass
{
  public static void Main (string[] args)
  {
    int b, c, k;
    Console.WriteLine("nota do primeiro bimestre");
    b = int.Parse(Console.ReadLine());
    
    Console.WriteLine("nota do segundo bimestre");
    c = int.Parse(Console.ReadLine());
    k = ( b * 2 + c * 3)/(2 + 3);
    Console.WriteLine("sua media e " + k);
}
}
