using System;

class Program {
//Elabore um algoritmo que calcule a idade média de 5 alunos.

  public static void Main (string[] args) {

   double media=0, M=0 ;
    
   int [] idade = new int[5];
    
    for(int i = 0; i<5;i++)
    {
      Console.Write("Digite a idade do aluno: ");
      idade[i] = int.Parse(Console.ReadLine());
      media += idade[i];  
    }
     M = media/5;
    Console.WriteLine("A média das idades dos anlunos é: {0} ", M);
    
  }
}