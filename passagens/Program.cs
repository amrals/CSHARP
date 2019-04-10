using System;

namespace passagens
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            DateTime[] data = new DateTime[10];
            bool continuar = true;
            string[] nome = new string [10];
            int[] numpass = new int [10];
            int i = 0;
            int a = 1;

            while (continuar)
            {
                System.Console.WriteLine("----------Bem vindo à Amarairlines----------");
                System.Console.WriteLine("Escolha uma opção:");
                System.Console.WriteLine("1- Registrar passagem");
                System.Console.WriteLine("2- Visualizar passagens");
                System.Console.WriteLine("0- Sair");

                resposta = (Console.ReadLine());

                switch (resposta)
                {
                    case "1":
                        if (i <=1)
                        {
                        Console.WriteLine("Insira seu nome");
                        nome[i] = Console.ReadLine();
                        System.Console.WriteLine("Insira o nº da passagem");
                        numpass[i] = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Insira a data de viagem!");
                        data[i] = DateTime.Parse(Console.ReadLine());
                        System.Console.WriteLine("---Passagem registrada!---");
                        i++;
                        }else
                        {
                            System.Console.WriteLine("---Número máximo de passagens atingido---");
                        }
                        break;
                    case "2":
                        a = 1;
                        for (a = 0; a < i; a++)
                        {
                            Console.WriteLine($"-----Passageiro: {nome[a]} \n  -----Nº da passagem:{numpass[a]} \n -----Para o dia:{data[a]:dd:MM:yyyy}\n -------------------- ");
                        }
                        break;
                    case "0":
                        System.Console.WriteLine("Obrigado pela preferência, volte sempre!");
                        continuar = false;
                        break;
                    default:
                        System.Console.WriteLine("-----Insira uma opção válida!-----");
                        break;
                }
            }
        }
    }
}
