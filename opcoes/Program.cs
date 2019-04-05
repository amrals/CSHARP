using System;

namespace opcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;//essa variável define o valor falso ou verdadeiro para iniciar ou encerrar o programa.

            while (repetir)//o while permite iniciar ou encerrar o programa, dependendo do valor da váriavel "repetir".
            {
                Console.WriteLine("Selecione uma opção desejada");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1- Para fazer LOGIN");
                Console.WriteLine("----------------------------");
                Console.WriteLine("2- Para acessar CONTATOS");//menu de opções exibido pelo programa.
                Console.WriteLine("----------------------------");
                Console.WriteLine("3- Para ir para a LISTA DE COMENTÁRIOS");
                Console.WriteLine("----------------------------");
                Console.WriteLine("9- Para sair do programa!");
                Console.WriteLine("----------------------------");

                int resposta = int.Parse(Console.ReadLine());//essa variável recebe a resposta dada ao menu anterior.

                switch (resposta)
                {//o switch permite reconhecer o valor da variável "resposta" inserida anteriormente, e dependendo do valor da mesma, exibe uma resposta diferente.
                    case 1:
                        Console.WriteLine("Você está em LOGIN");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("Digite seu usuário");
                        string usuario = Console.ReadLine();//coleta o nome do usuário
                        Console.WriteLine("Digite sua senha");
                        string senha = Console.ReadLine();//coleta a senha do usuário
                        if (usuario == "Matheus" && senha == "123")//SE a variável "usuário" tiver "Matheus" como valor, e a variável "senha" tiver "123" como valor, o console apresentará a mensagem.
                        {
                            Console.WriteLine("Bem vindo ao fut {0}", usuario);
                        }//fim do if
                        break;
                    case 2:
                        Console.WriteLine("Você está em CONTATOS");
                        Console.WriteLine("Nego ney Nego ney");
                        break;
                    case 3:
                        Console.WriteLine("Você está em COMENTÁRIOS");
                        Console.WriteLine("Parabéns aos desenvolvedores seu lindo rs!");
                        break;
                    case 9:
                        Console.WriteLine("Você saiu!");
                        repetir = false;//mudança de valor da variável "repetir", para que o programa encerre-se, pois o while foi comprometido.
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }//fim switch

            }//fim while

            
        }//fim main
    }
}
