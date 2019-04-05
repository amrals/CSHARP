using System;

namespace Previsao
{
    class Program
    {
        static void Main(string[] args)
        {
            string previsao;
            string resposta;

            Console.WriteLine("Diga-me a previsão do tempo, e lhe direi o que fazer!!!");

            Console.WriteLine("Digite a previsão do tempo");
            previsao = Console.ReadLine().ToLower();
            if (previsao.Equals("frio"))
            {
                Console.WriteLine("Vamos à montanha!");
            } else if (previsao.Equals("calor"))
            {
                Console.WriteLine("Vamos à praia!");
            } else if (previsao.Equals("chuva"))
            {
                Console.WriteLine("Vamos à Steam?");
                resposta = Console.ReadLine().ToLower();
                if (resposta.Equals("não")){
                    Console.WriteLine("Vamos à Netflix!");
                }
            } else
            {
                Console.WriteLine("Valor inválido \n Digite: Calor, Frio ou Chuva");
            }
        }
    }
}
