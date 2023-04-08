using System;

class Program {
  /*
  Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.
  */

  public static int Soma (int [] Ele, int N)
  {
    int somar = 0;
    
    if(Ele[N]%2 == 0)
    {
      return somar += Ele[N] + Soma(Ele, N+1);
    }
    else
    {
      return Soma(Ele,N+1);
    }
  }
  
  public static void Main (string[] args) {
    
    Console.Write("Digite o tamanho do vetor: ");
    int V = int.Parse(Console.ReadLine());
    
    int [] Ele = new int [V];
    for(int i =0; i<V; i++)
    {
      Console.Write("Digite um número para o vetor: ");
      Ele [i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine($"A soma dos elementos pares é {Soma(Ele,V)}");
  }
}