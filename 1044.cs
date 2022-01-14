using System; 

public class Program {

  public static void Main(string[] args) {

    Console.WriteLine("digite a");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("digite b");
    int b = int.Parse(Console.ReadLine());

    int K = b % a;
    int L = a % b;

    if(K == 0 || L == 0 || a == b)
    {
      Console.WriteLine("sao multiplos");
    }
    else
    {
      Console.WriteLine("nao sao multiplos");
    }
    
  }
}