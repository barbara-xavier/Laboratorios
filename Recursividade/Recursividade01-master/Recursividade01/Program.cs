namespace Recursividade01
{
    internal class Program
    {
        /*Escreva um método recursivo que retorne o fatorial de um número.*/

        public static int Fatorial(int N)
        {

            if (N == 0)
            {
                return 1;
            }
            else
            {
                return N * Fatorial(N - 1);
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Digite o número escolhido: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine($"O fatorial do número é: {Fatorial(N)}");

        }
    }
    }
}