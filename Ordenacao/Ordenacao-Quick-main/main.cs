using System;

class Program {

  public static void QuickSort(int[]V, int inicio, int fim)
  {
    if(inicio < fim)
    {
      int pivo = Quick(V, inicio, fim);
      QuickSort(V, inicio, pivo-1);
      QuickSort(V, pivo+1,fim);
    }
  }

  public static int Quick(int[]V, int inicio, int fim)
  {

    int pivo = V[fim];
    int part = inicio -1;
    int aux;

    for(int i=inicio; i<fim; i++)
    {
      if(V[i] < pivo)
      {
        part += 1;
        aux = V[part];
        V[part] = V[i];
        V[i] = aux;
      }
      
    }

    part++;
    aux = V[part];
    V[part] = V[fim];
    V[fim] = aux;

    return part;
    
  }

  public static void Main (string[] args) {

         int[] V = new int[6]{ 2, 8, 1, 20, 6, 15 };
       
     QuickSort(V, 0, V.Length-1);
       
       for(int i=0; i<V.Length; i++)
       {
         Console.Write($"{V[i]}, ");
         
       }
  
   }
}
