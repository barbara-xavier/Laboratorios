using System;
using System.IO;

class Program {
/*Desenvolva um algoritmo que solicite a entrada de nome, e-mail, telefone e RG de um determinado usuário e grave em um arquivo de texto. 
  Exiba as informações na tela a partir do arquivo de texto gerado.*/

  public struct pessoa
  {
    public string Nome;
    public string Email;
    public string Telefone;
    public string RG;
    public int Codigo;

    public void Cadastrar(int codigo)
    {
      Codigo = codigo;
     Console.Write("Digite seu nome: ");
     string Nome = Console.ReadLine();
     Console.Write("Digite seu email: ");
     string Email = Console.ReadLine();
     Console.Write("Digite seu telefone: ");
     string Telefone = Console.ReadLine();
     Console.Write("Digite seu RG: ");
     string RG = Console.ReadLine();

    }

    public override string ToString()
    {
        return ($"{Nome};{Email};{Telefone};{RG}");
    }
       public void Imprimir(){
      Console.WriteLine($"{Codigo} - {Nome} - {RG} - {Telefone} - {Email}");
    }

     public string DadosUsuario()
    {
        return ($"Nome: {Nome}. \nEmail: {Email}. \nTelefone: {Telefone} \nRG: {RG}.");
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
     Console.WriteLine("\nsuários:\n ");
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
            pc.WriteLine(Pessoas[i].ToString());

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
                Pessoas[i].Email = Pessoa[1];
                Pessoas[i].Telefone = Pessoa[2];
                Pessoas[i].RG = Pessoa[3];
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