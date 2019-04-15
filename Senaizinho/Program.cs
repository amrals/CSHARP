using System;

namespace Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            int i = 0;
            int contSala = 0;
            Aluno[] aluno = new Aluno[10];


            Console.WriteLine("-----Bem vindo à Secretaria Virtual-----");

            while (continuar)
            {
                System.Console.WriteLine("1 - Cadastrar Aluno");
                System.Console.WriteLine("2 - Cadastrar Sala");
                System.Console.WriteLine("3 - Alocar Aluno");
                System.Console.WriteLine("4 - Remover Aluno");
                System.Console.WriteLine("5 - Verificar Salas");
                System.Console.WriteLine("6 - Verificar Alunos");
                System.Console.WriteLine("0 - Sair");

                string resposta = Console.ReadLine();
                
                switch (resposta)
                {
                    case "1":
                        if (i < 5)
                        {
                        Aluno aluno1 = new Aluno();
                        System.Console.WriteLine("Digite o nome do aluno a ser cadastrado");
                        aluno1.nome = Console.ReadLine();
                        System.Console.WriteLine("Insira a data de nascimento do aluno");
                        aluno1.dataNascimento = System.DateTime.Parse(Console.ReadLine());
                        System.Console.WriteLine("Digite o curso do aluno");
                        aluno1.Curso = Console.ReadLine();
                        System.Console.WriteLine("Digite o número da sala do aluno");
                        aluno1.numeroSala = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("-----Aluno cadastrado-----");
                        
                        i++;
                        }else{
                            System.Console.WriteLine("-----Número máximo de alunos cadastrados atingido-----");
                        }
                        break;
                    case "2":
                        if (contSala < 2)
                        {
                        Sala sala1 = new Sala();
                        System.Console.WriteLine("Digite o número da sala a ser cadastrada");
                        sala1.numeroSala = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("-----Sala cadastrada-----");
                        contSala++;
                        }else{
                            System.Console.WriteLine("-----Número máximo de salas cadastradas-----");
                        }
                        break;
                    case "3":
                        System.Console.WriteLine("Digite o nome do aluno a ser alocado");
                        Console.ReadLine();
                        
                        break;
                    case "4":
                        System.Console.WriteLine("Digite o nome do aluno a ser removido");
                        Console.ReadLine();
                        
                        break;
                    case "5":
                        System.Console.WriteLine("Essas são as salas");
                        Console.ReadLine();
                        
                        break;
                    case "6":
                        System.Console.WriteLine("Esses são os alunos");
                        System.Console.WriteLine($"");
                        Console.ReadLine();
                        
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        System.Console.WriteLine("-----Digite um número válido-----");
                        break;
                }
            }
        }
    }
}
