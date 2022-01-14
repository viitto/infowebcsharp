using System; 

public class Program {

  public static void Main(string[] args) {
    int a1, a2, a3, K;
    Console.WriteLine("digite o A1");
    a1 = int.Parse(Console.ReadLine());
    Console.WriteLine("digite o A2");
    a2 = int.Parse(Console.ReadLine());
    Console.WriteLine("digite o A3");
    a3 = int.Parse(Console.ReadLine());

    if(a1 > a2 && a1 > a3){
      K = (a1 * 0) + (a2 * 2) + (a3 * 4);
      Console.WriteLine(K);
    }
    if(a2 > a1 && a2 > a3){
      K = (a2 * 0) + (a1 * 2) + (a3 * 2);
      Console.WriteLine(K);
    }
    if(a3 > a1 && a3 > a2){
      K = (a3 * 0) + (a2 * 2) + (a1 * 4);
      Console.WriteLine(K);
    }
    
  }
}