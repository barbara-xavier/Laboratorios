using System;

class Program {
  /*Faça um programa que chame uma função capaz de calcular x^y, sendo x e y inteiros. Utilize passagem de parâmetros por referência.*/

  public static double Calcular(ref int x, int y)
  {
    double valor = Math.Pow(x,y);
    
    return valor;
  }

  
  public static void Main (string[] args) {
    
    Console.Write("Digite o valor de x: ");
    int X = int.Parse(Console.ReadLine());

    Console.Write("Digite o valor de y: ");
    int Y = int.Parse(Console.ReadLine());

    Console.Write($"O resultado final é {Calcular(ref X,Y)}");
    
  }
}