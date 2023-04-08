using System;

class Program
{
    //Desenvolva uma calculadora, onde será necessário entrar com a operação, primeiro e segundo valor, exiba o resultado na tela.

    static int Menu()
    {
        Console.Write("\nSelecione a operação desejada: ");
        Console.Write("\n1 - Adição \n2 - Subtração \n3- Divisão \n4 - Multiplicação \n--> ");
        int opcao = int.Parse(Console.ReadLine());

        return opcao;
    }

    public static void Main(string[] args)
    {
        double calculo = 0;
        Console.Write("Digite o primeiro valor: ");
        double N1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        double N2 = double.Parse(Console.ReadLine());

        int op = 0;
        op = Menu();

        switch (op)
        {
            case 1:
                calculo = N1 + N2;
                Console.WriteLine("A soma dos números é: {0}", calculo);
                break;
            case 2:
                calculo = N2 - N2;
                Console.WriteLine("A subtrção dos números é: {0}", calculo);
                break;
            case 3:
                calculo = N1 / N2;
                Console.WriteLine("A divisão dos números é: {0}", calculo);
                break;
            case 4:
                calculo = N1 * N2;
               Console.WriteLine("A multiplicação dos números é: {0}", calculo);
                break;
            default:
                Console.WriteLine("OPÇÃO INVÁLIDA!!");
                break;
        }





    }
}