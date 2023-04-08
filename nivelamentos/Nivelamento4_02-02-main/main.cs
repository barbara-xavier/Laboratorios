using System;

class Program {

  //Faça um algoritmo que leia a altura e a matricula de dez alunos. Mostre a matricula do aluno mais alto e do aluno mais baixo.

  public static void Main (string[] args) {
    int [] matricula = new int [10];
    double [] altura = new double [10];
    
    int maiorA = 0;
    int menorA = 0;

    for(int i=0; i<5;i++)
    {
      Console.Write("Digite a altura do aluno: ");
      altura[i] = double.Parse(Console.ReadLine());

      
      Console.Write("Digite a matrícula do aluno: ");
      matricula[i] = int.Parse(Console.ReadLine());
      
    }

    for(int i=0; i<5; i++)
    {
      if(altura[maiorA] < altura[i])
      {
        maiorA = i;
      }
    }

    for(int i=0; i<5; i++)
    {
      if(altura[menorA] > altura[i])
      {
        menorA = i;
      }
    }

    Console.WriteLine("A matricula do aluno mais alto é: {0} \nA matricula do aluno mais baixo é: {1}", matricula[maiorA], matricula[menorA]);
    
  
  }
}