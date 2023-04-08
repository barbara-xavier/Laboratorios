using System;

class Program {
  public static void Selection (int[]V){
  
        int aux=0, menor;

     for(int i = 0; i < V.Length; i++)
     {
       menor = i;
       
       for(int j = i + 1; j < V.Length; j++)
       {
         if(V[j] < V[menor])
         {
           menor = j;
         }
        
       }
         aux = V[i];
         V[i] = V[menor];
         V[menor] = aux;
     }
  }

    
  public static void Main (string[] args) {
    
   int[] V = new int[6] { 2, 8, 1, 20, 6, 15 }; 
     
      Selection(V);
     for(int i = 0; i < V.Length; i++)
     {
       Console.Write("{0} ", V[i]);
     }

     

     



     
  }
}