using System;

class Program {
  /*
  Escreva um método recursivo que realize a potenciação entre dois números inteiros, A e B, recebidos por parâmetro. Seu método deve, portanto, retornar o resultado de A^B
  */

  public static int Potencia (int A, int B)
  {
    if(B == 0)
    {
      return 1;
    }
    else
    {
      return A * Potencia(A, B-1);
    }
  }
  
  public static void Main (string[] args) {
    
    Console.Write("Digite o primeiro número: ");
    int A = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    int B = int.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da potênciação é {Potencia(A,B)}");
  }
}