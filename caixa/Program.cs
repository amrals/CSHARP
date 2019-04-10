using System;

namespace caixa
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorSaque = 0;
            int [] notas = {1, 2, 5, 10, 20, 50, 100};
            DateTime data = DateTime.Now;

            Console.WriteLine("Caixa eletrônico");
            Console.WriteLine("Qual o valor do saque?");
            valorSaque = int.Parse(Console.ReadLine());


            for (int i = notas.Length -1; i >= 0 ; i--)
            {
                int qntNotas = valorSaque / notas[i];
                int restante = valorSaque % notas[i];
                valorSaque = restante;
                 
                if (qntNotas != 0)
                {
                    System.Console.WriteLine($"Você recebeu {qntNotas} nota(s) de {notas[i]} em {data}");
                }
            }
        }
    }
}
