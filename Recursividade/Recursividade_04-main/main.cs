using System;

class Program {
  /*Escreva um método recursivo que receba uma frase e uma letra como parâmetros. Este método deve retornar a quantidade de ocorrências desta letra nesta frase. */

      static int ContarLetras(string frase, char letra) {
        if (frase.Length == 0) {
            return 0;
        }
        else {
            int ocorrenciasRestantes = ContarLetras(frase.Substring(1), letra);
            if (frase[0] == letra) {
                return ocorrenciasRestantes + 1;
            }
            else {
                return ocorrenciasRestantes;
            }
          }
        }

  public static void Main (string[] args) {
    
      Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();
        Console.Write("Digite uma letra: ");
        char letra = char.Parse(Console.ReadLine());
        int qtOcorrencias = ContarLetras(frase, letra);
        Console.WriteLine($"A letra {letra} aparece {qtOcorrencias} vezes na frase.");

  }
}