using System;

class Program {
  //Desenvolva um algoritmo que calcule o reajuste salarial. Se o salário for abaixo de 1.700 o ajuste é de R$300.00, se maior de R$ 200.00. Para finalizar, exiba o novo salário na tela.

  public static void Main (string[] args) {
    
    Console.Write("Digite o salário atual: ");
    double salario = double.Parse(Console.ReadLine());

    if(salario > 1700)
    {
      salario += 200.00;
       Console.WriteLine("O novo salário (+200) é: {0}", salario);
    }
    else{
      salario += 300.00;
       Console.WriteLine("O novo salário (+300) é: {0}", salario);
    }

   

    
  }
}