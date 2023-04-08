using System;

class Program
{
    /*
    Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras 
  palavras, um Número Primo possui dois divisores de 1 até ele.
  Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é 
  Primo.

  Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por 
  exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6.
  Faça um programa que liste os números perfeitos de 1 a 1000.*/

    static void Primo(int N)
    {
      for(int i=1; i<N;i++)
      {
         if (N % i == 0)
        {
            Console.Write(" {0} NÃO é primo", N);
        }
      }
            Console.Write(" {0} é primo", N);
       
    }

  static void Perfeito(int N)
  {
    int soma=0;
    for(int i=1; i<N; i++)
    {
      if(N%i == 0)
      {
        soma += i;
      }
    }
    if(soma == N)
    {
      Console.Write("{0}\n",N);
    }
  }

    public static void Main(string[] args)
    {

        Console.Write("Digite um número: ");
        int N = int.Parse(Console.ReadLine());
        Primo(N);

      Console.Write("\nOs números perfeitos de 1 a 1000 são:\n ");
      for(int i=1; i<=1000;i++)
      {
        Perfeito(i);
      }

    }
}