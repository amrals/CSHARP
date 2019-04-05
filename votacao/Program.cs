using System;

namespace votacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double ano;
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("Me dê seu ano de nascimento muahaha!!!");
            ano = double.Parse(Console.ReadLine());

            if (ano <= 2003)
            {
                Console.WriteLine("Vai votar AGORA CARA!!!");
            } else if (ano > 2003)
            {
                Console.WriteLine("Sinto muito cara vc nao pode votar");
            }
        }
    }
}
