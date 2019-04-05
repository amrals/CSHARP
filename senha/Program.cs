using System;

namespace senha
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Me dê sua senha muahahaha!!!");
            senha = int.Parse(Console.ReadLine());

            if (senha == 1234)
            {
                Console.WriteLine("Acesso concedido");
            } else
            {
                Console.WriteLine("Acesso negado");
            }
        }
    }
}
