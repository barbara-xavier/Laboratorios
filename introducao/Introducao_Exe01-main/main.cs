using System;

class Program
{
    /*Número = 3025 
      Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
       A soma de 30 com 25 é igual a 55
       O Quadrado de 55 é igual a 3025.
      Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.*/

    static void Separar (int N)
    {
      double N1 = N/100; 
      double N2 = N%100;
      double soma = N1+N2;

      if(Math.Pow(soma,2) == N)
      {
        Console.WriteLine("{0} possúi a característica particular", N);
      }

    }

    public static void Main(string[] args)
    {
        for(int i=1000; i<= 9999; i++)
      {
          Separar(i);
      }
    }
}