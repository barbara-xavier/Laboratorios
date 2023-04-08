using System;
// Dividir a lista em sublista
// A metade da esquerda vai do meio até o fim da lista
// A metade da direita vai do meio até o inicio da lista



class Program {

    public static void MergeSort(int[]V,int inicio, int fim)  
  {
      if(inicio < fim)
    {
      int meio = (inicio + fim)/2;
      MergeSort(V, inicio, meio);
      MergeSort(V, meio+1, fim);
      Merge(V, inicio, meio, fim);  
      
    }
  }

  public static void Merge(int[]V, int inicio, int meio, int fim)
  {
    int v1 = meio - inicio +1;
    int v2 = fim - meio;

    //primeira e segunda metade do vetor

    int[] esquerda = new int[v1];
    int[] direita = new int[v2];

    for(int i=0; i<v1; i++)
    {
      esquerda[i] = V[inicio + i];
    }
    
    for(int j=0; j<v2; j++)
    {
      direita[j] = V[meio + 1 + j];
    }
    
    //indices dos vetotes
    int x = 0;
    int y = 0;
    int k = inicio;

    while(x < v1 && y < v2)
    {
      if(esquerda[x] <= direita[y])
      {
        V[k] = esquerda[x];
        x++;
      }
      else{
        V[k] = direita[y];
        y++;
      }
      k++;
    }

    while(x < v1)
    {
      V[k] = esquerda[x];
      x++;
      k++;
    }

    while(y < v2)
    {
      V[k] = direita[y];
      y++;
      k++;
    }
    
    
    
  }
  
   
  public static void Main (string[] args) {

      int[] V = new int[6]{ 3, 8, 1, 20, 6, 16 };

      MergeSort(V, 0, V.Length - 1);
        
      for(int i=0; i<V.Length; i++)
        {
          Console.Write($"{V[i]}, ");
        }
     
  }
}

