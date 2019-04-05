using System;

namespace Balada
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            Console.WriteLine("Vamos ver se dá pra ir na balada!!!");
            Console.WriteLine("Você tem disponibilidade pra ir?");
            resposta = Console.ReadLine();
            if (resposta.Equals("não"))
            {
                Console.WriteLine("Por que não?");
                Console.ReadLine();
                Console.WriteLine("Vai embora");
            }
            else if (resposta.Equals("sim"))
            {
                Console.WriteLine("Que topzera! \n Vamos pra próxima pergunta!");
                Console.WriteLine("Você tem idade pra ir nisso ai cara?");
                resposta = Console.ReadLine();
                if (resposta.Equals("não"))
                {
                    Console.WriteLine("Por que não? oxe");
                    Console.ReadLine();
                    Console.WriteLine("Sinto mto man");
                }
                else if (resposta.Equals("sim"))
                {
                    Console.WriteLine("Beleza, bora pra próxima pergunta!");
                    Console.WriteLine("Você tem pulseira VIP ou pagou entrada?");
                    Console.ReadLine();
                    if (resposta.Equals("não"))
                    {
                        Console.WriteLine("Por que nao cara?");
                        Console.ReadLine();
                    }
                    else if (resposta.Equals("sim"))
                    {
                        Console.WriteLine("TOOOOOP");
                    }
                }


            }

        }
    }
}
