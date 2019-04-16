using System;

namespace Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            int i = 0;
            int cont = 0;
            Aluno[] alunos = new Aluno[4];
            Sala[] salas = new Sala[1];
            int cadastrados = 0;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----- Bem vindo à Secretaria Virtual -----");
            Console.ResetColor();

            while (continuar)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("1 - Cadastrar Aluno");
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine("2 - Cadastrar Sala");
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("3 - Alocar Aluno");
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("4 - Remover Aluno");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine("5 - Verificar Salas");
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine("6 - Verificar Alunos");
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("0 - Sair");
                Console.ResetColor();

                string resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        if (i < 4)
                        {
                            Aluno aluno = new Aluno();
                            System.Console.WriteLine("Digite o nome do aluno a ser cadastrado");
                            aluno.nome = Console.ReadLine();
                            System.Console.WriteLine("Insira a data de nascimento do aluno");
                            aluno.dataNascimento = System.DateTime.Parse(Console.ReadLine());
                            System.Console.WriteLine("Digite o curso do aluno");
                            aluno.Curso = Console.ReadLine();
                            System.Console.WriteLine("Digite o número da sala do aluno");
                            aluno.numeroSala = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("----- Aluno cadastrado -----");
                            Console.ResetColor();
                            alunos[cadastrados] = aluno;
                            cadastrados += 1;
                            i++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("----- Número máximo de alunos cadastrados atingido -----");
                            Console.ResetColor();
                        }
                        break;
                    case "2":
                        if (cont < 1)
                        {
                            Sala sala1 = new Sala();
                            System.Console.WriteLine("Digite o número da sala a ser cadastrada");
                            sala1.numeroSala = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("Digite a capacidade total da sala");
                            sala1.capacidadeTotal = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("----- Sala cadastrada -----");
                            Console.ResetColor();
                            salas[cont] = sala1;
                            sala1.Alocar(alunos[i].nome);
                            cont += 1;
                            cont++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("----- Número máximo de salas cadastradas -----");
                            Console.ResetColor();
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
                        for (int a = 0; a < 1; a++)
                        {
                            System.Console.WriteLine("----------------------------------------");
                            System.Console.WriteLine("Número da sala: "+salas[a].numeroSala);
                            System.Console.WriteLine("Capacidade total: "+salas[a].capacidadeTotal);
                            System.Console.WriteLine("----------------------------------------");
                        }
                        break;
                    case "6":
                        System.Console.WriteLine("Esses são os alunos");
                        for (int a = 0; a < 4; a++)
                        {
                            System.Console.WriteLine(alunos[a].nome);
                        }
                        break;
                    case "0":
                        System.Console.WriteLine("Obrigado por acessar!!!");
                        continuar = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("----- Digite um número válido -----");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}
