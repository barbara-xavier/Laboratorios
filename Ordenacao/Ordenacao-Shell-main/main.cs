using System;

class Program {
  
    public static void ShellSort(int[]V)
  {
    int n = V.Length;
    int aux = n/2;
    ShellRecursivo(V,aux);
  }

    public static void ShellRecursivo(int[]V, int aux)
  {

    if(aux > 0)
    {
      while(aux > 0)
    {
      for(int i = aux; i< V.Length; i++)
      {
        int valorAtual = V[i];
        int j = i;

        while(j >= aux && V[j- aux] > valorAtual)
        {
          V[j] = V[j-aux];
          j -= aux;
        }
        V[j] = valorAtual;
      }
      aux /= 2;
    }

    }else
    {
      //quando aux for igual a 1, chama o ShellSort normal
      Array.Sort(V);
    }
    
  
  }


  public static void Main (string[] args) {
    int[] V = new int[6] { 2, 8, 1, 20, 6, 15 }; 

    ShellSort(V);

      for(int i=0; i<V.Length; i++)
      {
        Console.Write($"{V[i]}, ");
      }
  }
}

