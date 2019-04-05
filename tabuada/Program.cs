using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool replay = true;
            string resposta;

            Console.WriteLine("Bem vindo à Tabuada Digital!!!");
           

            while (replay)
            {
                Console.WriteLine("Insira o número da tabuada!");
                int num = int.Parse(Console.ReadLine());
                int cont = 0;

                while (cont <= 10)
                {
                Console.WriteLine(num+"x"+cont+"="+num*cont);
                cont++;
                }

                Console.WriteLine("Você ainda quer jogar?");
                resposta = Console.ReadLine();
                replay = resposta.Equals("sim") ? true : false;
            }
            
        }
    }
}
