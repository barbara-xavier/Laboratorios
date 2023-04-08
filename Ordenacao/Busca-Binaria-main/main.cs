using System;

class Program {

  static int PesquisaBinaria(int[]V, int chave)
  {
    
    int meio;
    int inicio=0;
    int fim = V.Length-1;

  
    do{
      meio = (int)(inicio + fim)/2; 
    
      if(V[meio] == chave)
      {
      
        return meio; 
      }else{
        if(chave > V[meio])
        {
          inicio = meio+1;
        }
        else{
          fim = meio+1;
        }
      }
    }while(inicio <= fim);
 
    return -1;
  }
  
  public static void Main (string[] args) {
   int[] V = new int[10]{1,2,3,4,5,6,7,8,9,10};
     int n = 7;
    Console.WriteLine ($"O número procurado é: {PesquisaBinaria(V,n)}");
  }
}