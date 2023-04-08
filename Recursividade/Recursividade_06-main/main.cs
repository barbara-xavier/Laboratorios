using System;

class Program {
  /*
  Escreva um método recursivo que receba uma frase e retorne a mesma frase, sem nenhuma vogal. 
  */

  public static string TiraVogal (string frase)
  {
    string retirar = frase.Replace("A", "")
                               .Replace("a", "")
                               .Replace("E", "")
                               .Replace( "e", "")
                               .Replace( "I","")
                               .Replace("i", "")
                               .Replace("O","")
                               .Replace("o", "")
                               .Replace("U", "")
                               .Replace("u","");
  return retirar;
    
    //replace = substituição de caracter
  }
  
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase: ");
    string frase = Console.ReadLine();

    Console.WriteLine($"\n{TiraVogal(frase)}");
  }
}