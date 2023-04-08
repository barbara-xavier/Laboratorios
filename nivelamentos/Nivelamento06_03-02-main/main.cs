using System;

class Program
{
    //Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário, se for menor que 18 anos exiba na cor vermelha “Sem permissão”, caso seja maior ou igual a 18 anos exiba na cor verde “Permissão concedida”.

    public static void Main(string[] args)
    {

        Console.Write("Digite a sua idade atual: ");
        int idade = int.Parse(Console.ReadLine());
      
        if (idade < 18)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Sem permissão");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Permissão concedida");
        }

    }
}