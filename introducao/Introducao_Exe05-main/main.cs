using System;

class Program {
  
  /*Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.*/

  public static int Fatorial(int N)
  {
    if(N == 0)
    {
      return 1;
    }
    else
    {
      return N * Fatorial(N-1);
    }
  }
  
  public static void Main (string[] args) {
    
    Console.Write("Digite um número inteiro: ");    
    int N = int.Parse(Console.ReadLine());

    Console.Write($"O fatoral do número {N} é {Fatorial(N)}");
    
  }
}