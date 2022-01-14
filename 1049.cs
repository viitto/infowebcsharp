// 1049
using System; 

public class Program {

  public static void Main(string[] args) {

    Console.WriteLine("digite x");
    string x = Console.ReadLine();
    Console.WriteLine("digite y");
    string y = Console.ReadLine();
    Console.WriteLine("digite z");
    string z = Console.ReadLine();
    string a = x + y + z;

     switch(a)
     {
       case "vertebradoavecarnivoro" : Console.WriteLine("aguia"); break;
       case "vertebradoaveonivoro" : Console.WriteLine("pomba"); break;
       case "vertebradomamiferoonivoro" : Console.WriteLine("homem"); break;
       case "vertebradomamiferoherbivoro" : Console.WriteLine("vaca"); break;
       case "invertebradoinsetohematofago" : Console.WriteLine("pulga"); break;
       case "invertebradoinsetoherbivoro" : Console.WriteLine("lagarta"); break;
       case "invertebradoanelideohematofago" : Console.WriteLine("sanguessuga"); break;
       case "invertebradoanelideoonivoro" : Console.WriteLine("minhoca"); break;
     }
    
      // Console.WriteLine(a);
    
    
    
  }
}