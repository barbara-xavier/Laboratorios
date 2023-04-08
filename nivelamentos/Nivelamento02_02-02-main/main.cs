using System;

class Program {
  //Crie um algoritmo que verifique se um número informado é par ou impar

  public static void Main (string[] args) {
    
    int N;

    Console.Write("Digite um número: ");
    N = int.Parse(Console.ReadLine());

    if(N%2==0)
      {
         Console.WriteLine("Este número é Par");
      }
    else
    {
      Console.WriteLine("Este número é Impar");
    }
    
  }
}