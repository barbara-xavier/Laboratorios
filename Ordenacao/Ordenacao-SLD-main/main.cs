using System;

class Program {

   
  public static void LSD(int[] V)
{
      int max = V[0];
    for (int i = 1; i < V.Length; i++)
    {
        if (V[i] > max)
        {
            max = V[i];
        }
    }
  for (int expoente = 1; max / expoente > 0; expoente *= 10)
    {
        CountingSort(V, expoente);
    }

}

  public static void CountingSort(int[] V, int expoente)
{
 
    int[] vetorOrdenado = new int[V.Length];
    int[] countV = new int[10];

  
    for (int i = 1; i < V.Length; i++)
    {
      int digito = (V[i]/expoente) % 10;
      countV[digito]++;
    }

  
    for (int i = 1; i < countV.Length; i++)
    {
        countV[i] += countV[i-1];
    }

   
    for (int i = V.Length-1; i >= 0; i--)
    {
        int digito = (V[i]/expoente)%10;
        vetorOrdenado[countV[digito]-1] = V[i];
        countV[digito]--;
    }

    for (int i = 0; i < V.Length; i++)
    {
       V[i] = vetorOrdenado[i];
    }
   
}

  
  public static void Main (string[] args) {
   int[] V = new int[7] { 5, 2, 7, 3, 1, 6, 4 };
    LSD(V);
        
 
    for (int i=0; i<V.Length;i++)
    {
      Console.Write($"{V[i]}, ");
    }
  }
}