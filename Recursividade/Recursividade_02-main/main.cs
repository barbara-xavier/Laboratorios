using System;

class Program {
  /*
  Uma multiplicação pode ser vista como uma sequência de somas. Escreva um método recursivo que realize a multiplicação de dois números inteiros, A e B, recebidos por parâmetro.
  */

   static int Somas(int A, int B)
  {
    if(A == 0 || B == 0)
    {
      return 0;
    }
    else
    {
      return A + Somas(A, B-1);
    }
  }
  
  public static void Main (string[] args) {
    
    Console.Write("Digite um número: ");
    int A = int.Parse(Console.ReadLine());
    Console.Write("Digite outro número: ");
    int B = int.Parse(Console.ReadLine());

    Console.WriteLine($"A multiplicação desses números é: {Somas(A,B)} ");
  }
}