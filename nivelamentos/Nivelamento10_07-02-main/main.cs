using System;

/*Desenvolva um algoritmo que calcule o IMC de uma determinada pessoa, e grave os resultados em um arquivo de texto, onde ao acessar a aplicação será solicitado se quer fazer um novo cadastro ou consultar os existentes. Cadastrando um novo cálculo de IMC, será necessário informar o nome, idade, peso e altura. O cálculo do IMC é feito dividindo o peso (em quilogramas) pela altura (em metros) ao quadrado. Ao gravar em um arquivo de texto, os dados anteriores deverão ser mantidos.*/

class Program {

  
  public struct pessoa
  {
    public string Nome;
    public int Idade;
    public double Peso;
    public double Altura;
    public int Codigo;
    public double IMC;

    public void Cadastrar(int codigo)
    {
      Codigo = codigo;
     Console.Write("Digite seu nome: ");
     string Nome = Console.ReadLine();
     Console.Write("Digite sua idade: ");
     int Idade = int.Parse(Console.ReadLine());
     Console.Write("Digite seu Peso: ");
     double Peso = double.Parse(Console.ReadLine());
     Console.Write("Digite sua Altura: ");
     double Altura = double.Parse(Console.ReadLine());
      IMC = Peso/(Math.Pow(Altura,2));

    }

    public override string ToString()
    {
        return ($"{Nome};{Idade};{Peso};{Altura};{IMC}");
    }
       public void Imprimir(){
      Console.WriteLine($"{Codigo} - {Nome} - {Altura} - {Peso} - {Idade} - {IMC}");
    }

     public string DadosUsuario()
    {
        return ($"Nome: {Nome}. \nIdade: {Idade}. \nPeso: {Peso} \nAlturA: {Altura} \nIMC: {IMC}");
    }

  }
  
 public struct Arquivos
 {
  public int MAX;
  public int np;
  public int sequencia;
  public pessoa [] Pessoas;

  public Arquivos(int quantidade) 
  {
    MAX = quantidade;
    np = 0;
    sequencia = 1;
    Pessoas = new pessoa[MAX];
  }

   public void Imprimir(){
     Console.WriteLine("\nUsuários:\n ");
      for(int i=0; i<np;i++){
        Pessoas[i].Imprimir();
      }
    }

  public void Cadastrar()
  {
      if(np == MAX)
      {
        Console.WriteLine("Arquivo lotado!");
      }
      else
      {
        Pessoas[np++].Cadastrar(sequencia++);
      }
  }

  public void Gravar ()
  {
    StreamWriter pc = new StreamWriter("pessoa.txt");
    pc.WriteLine(np);

      for (int i = 0; i < np; i++)
    {
        pc.WriteLine(Pessoas[i].ToString());
    }
      pc.Close();
  }

  public void LerPessoa()
  {
    try
    {
      StreamReader sr = new StreamReader("Pessoa.txt");

      np = int.Parse(sr.ReadLine());
            for (int i = 0; i < np; i++)
            {
                string[] Pessoa = sr.ReadLine().Split(";");
                Pessoas[i].Codigo = int.Parse(Pessoa[0]);
                Pessoas[i].Nome = Pessoa[0];
                Pessoas[i].Idade = int.Parse(Pessoa[1]);
                Pessoas[i].Peso = double.Parse(Pessoa[2]);
                Pessoas[i].Altura = double.Parse(Pessoa[3]);
                Pessoas[i].IMC = double.Parse(Pessoa[4]);
            }
            sequencia = Pessoas[np - 1].Codigo + 1;

            sr.Close();
    }
    catch{}
  } 
 }

        
   static int Menu()
        {
            int op = 0;
            Console.WriteLine("1 - Cadastrar novo usuário");
            Console.WriteLine("2 - Ler o arquivo");
            Console.WriteLine("0 - Sair");
            op = int.Parse(Console.ReadLine());
            return op;
        }
  


  
  public static void Main (string[] args) {

         Arquivos cP = new Arquivos(10);
    cP.LerPessoa();
    int op=0;

     do{
     op = Menu();
      switch(op){
        case 1:
         cP.Cadastrar();
        break;
        case 2:
         cP.Imprimir();
        break;
          
        case 0:
          cP.Gravar();
          Console.WriteLine("\n\nEncerrando o programa...\n\n");
          break;
        default: Console.WriteLine("\n\nOpção Invalida!!!\n\n");
          break;  
      }
    }while(op != 0);



    
  }
}