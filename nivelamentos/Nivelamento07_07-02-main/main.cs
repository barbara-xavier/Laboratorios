using System;

class Program
{
    //Desenvolva um algoritmo que solicite a entrada de uma frase, após isto troque todas as letras “A” ou “a” por “&”, porém não utilize o método Replace().

        static string Letra(string frase)
        {

            string conversao = "";
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'A' || frase[i] == 'a')
                {
                    conversao += '&';
                }
                else
                {
                    conversao += (char)(frase[i]);
                }

            }
            return conversao;

        }

        public static void Main(string[] args)
        {
            string frase, f;
          
            Console.WriteLine("Escreva uma frase: ");
            frase = Console.ReadLine();
          
            f = Letra(frase);
            Console.WriteLine("A frase ficou assim: {0}", f);


        }
}