using System;

class Program {
  //Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.

  public static void Main (string[] args) {
    
    int quantidade=0;
    int[] idade = new int[5];

    for(int i=0; i<5;i++)
    {
      Console.Write("Digite a idade da pessoa: ");
      idade[i] = int.Parse(Console.ReadLine());
      if(idade[i] > 18)
      {
        quantidade += 1;
      }
    }
    Console.WriteLine("A quantidade de pessoas maiores de 18 anos é: {0}", quantidade);
    
    }
}