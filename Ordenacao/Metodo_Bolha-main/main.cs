using System;

class Program {
  /*Método Bolha */

  public static void Bolha (int[]V){
    
     int teste = V.Length-1;
     int aux=0; 
       
            for (int i = teste; i >= 0; i--)
            {
              for(int j=0; j<=i ;j++)
              {
                if (V[j] > V[i])
                {
                aux = V[j];
                V[j] = V[i];
                V[i] = aux;
                } 
              }
            }     

      
  }
  public static void Main (string[] args) {
    
     int[] V = new int[6] { 2, 8, 1, 20, 6, 15 };
           
      Bolha(V);
            for(int i=0; i<V.Length;i++)
            {
              Console.Write("{0}, ", V[i]);
            }
            
  }
}
  