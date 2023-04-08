using System;

class Program {
  /*Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. 
Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.*/
  
  public static void Main (string[] args) {
    int L=5, C=3;
    int [,] M = new int [L,C];
    int [] SomaL = new int [L];
    int [] SomaC = new int [C];

    for(int i=0; i<L;i++)
    {
      for(int j=0; j<C;j++)
      {
        Console.Write("Digite um número para a matriz: ");
        M[i,j] = int.Parse(Console.ReadLine());
      }
    }

    for(int i=0; i<L; i++)
    {
      for(int j=0; j<C; j++)
      {
        SomaL[i] += M[i,j];  
      }
      Console.Write($"\nA soma da linha {i+1} = {SomaL[i]} ");
    }

    for(int i=0; i<L;i++)
    {
      for(int j=0;j<C;j++)
      {
        SomaC[j] += M[i,j];
      }
    }
    for(int j=0;j<C;j++)
    {
      Console.Write($"\nA soma da coluna {j+1} = {SomaC[j]} ");
    }
    
  }
}