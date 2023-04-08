using System;

class Program
{
    /*
    Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. 
  Considere que nenhum dos vetores possui elementos repetidos.

  Crie um vetor resultante C que possua os elementos comuns entre A e B.
  Crie um vetor resultante D que contenha os elementos de A que não existam em B.
    */

    public static void Main(string[] args)
    {
         int count = -1;
            int[] A = new int[5];
            int[] B = new int[5];
            int[] C = new int[5];
            int[] D = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite um valor para o vetor A: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite um valor para o vetor B: ");
                B[i] = int.Parse(Console.ReadLine());
            }

            // verificar se possúi elementos iguais


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (A[i] == B[j])
                    {
                        count++;
                        C[count] = A[i];
                    }
                }
            }


            //Verificar se possui elementos diferentes

            for (int i=0; i<5;i++)
            {
                
                    if (A[i] != B[i])
                    {
                        D[i] = A[i];

                    }
                
            }

            Console.WriteLine();
   
           
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Elementos do vetor C[{i}]: {C[i]}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Elementos do vetor D[{i}]: {D[i]}");
            }

        }

    }
}