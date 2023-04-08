using System;

class Program {

  public static void Insertion(int[]V)
  {

      int aux=0;

    for(int i = 1; i < V.Length; i++ )
      {
        int j = i;

        while (j > 0 && V[j] < V[j-1])
        {
          aux = V[j];
          V[j] = V[j-1];
          V[j-1] = aux;
          j -= 1;
          
        }
      }
  }
    
  
  public static void Main (string[] args)
  {
    int[] V = new int [6] {2, 8, 1, 20, 6, 15};

      Insertion(V);
      for(int i = 0; i < V.Length;i++)
      {
       Console.Write("{0}, ", V[i]); 
      }
  }
}