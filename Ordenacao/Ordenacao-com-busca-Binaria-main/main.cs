using System;

class Program {


  public static void BuscaBinariaOrdenada(int [] V, int inicio, int fim){
    
    if(inicio < fim){
        int meio = (inicio + fim) /2;
        BuscaBinariaOrdenada(V, inicio, meio);
        BuscaBinariaOrdenada(V, meio +1, fim);
        V = Intercalacao(V, inicio, fim);
    }
    
  }

  public static int [] Intercalacao(int [] V, int inicio, int fim){
   int [] aux = new int[V.Length];
    
    for(int i = inicio; i<=fim; i++)
    {
      aux[i] = V[i];
    }
    
    int V2 = inicio; 
    int esquerdo = inicio; 
    int meio = (inicio + fim)/2; 
    int k = meio + 1; 
    
    while(esquerdo <= meio && k <= fim){

      if(aux[esquerdo] > aux[k])
      {
        V[V2] = aux[k];
        k++;
      }else{
        V[V2] = aux[esquerdo];
        esquerdo++;
      }
      V2++;   
    }

    while(esquerdo <= meio)
    {
      V[V2] = aux[esquerdo];
      V2++;
      esquerdo++;
    }

    while(k <= fim)
    {
      V[V2] = aux[k];
      k++;
      V2++;
    }

    return V;

  }
  
  public static void Main (string[] args) {
    
    int [] V= new int [7] {15,8,9,2,55,7,61};
      
      
    BuscaBinariaOrdenada(V, 0, 6);
      
    for(int i=0; i<V.Length;i++){
      Console.Write($"{V[i]}, ");
    }
      
  }
}
