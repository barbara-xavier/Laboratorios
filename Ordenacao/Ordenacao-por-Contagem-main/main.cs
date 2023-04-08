using System;

class Program {


  public static int[] CountingSort(int[] V)
{
 
    int[] sortedV = new int[V.Length];

    // Encontra o maior elemento do array de entrada
    int max = V[0];
    for (int i = 1; i < V.Length; i++)
    {
        if (V[i] > max)
        {
            max = V[i];
        }
    }

    // Cria o array de contagem com o tamanho máximo encontrado
    int[] countV = new int[max + 1];

    // Incrementa a contagem para cada valor do array de entrada
    for (int i = 0; i < V.Length; i++)
    {
        countV[V[i]]++;
    }

    // Acumula a contagem em cada posição com a contagem da posição anterior
    for (int i = 1; i < max + 1; i++)
    {
        countV[i] += countV[i - 1];
    }

    // Preenche o array de saída com os elementos na ordem correta
    for (int i = V.Length - 1; i >= 0; i--)
    {
        sortedV[countV[V[i]] - 1] = V[i];
        countV[V[i]]--;
    }

    return sortedV;
}
  
  public static void Main (string[] args) {
    
    int[] V = new int[7] { 5, 2, 7, 3, 1, 6, 4 };
     int[] V2 = CountingSort(V);
        
 
    for (int i=0; i<V.Length;i++)
    {
      Console.Write($"{V2[i]}, ");
    }
     
  }
}