using System;

namespace exarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeroCasas = new int[5];

            int cont = 0;
            while (cont < numeroCasas.Length)
            {
                
                Console.WriteLine("Digite o número da casa");
                numeroCasas[cont] = int.Parse(Console.ReadLine());

                cont++;
            }
           Console.WriteLine($"Exibir valor indice 3 = {numeroCasas[0]}");

        }
    }
}
