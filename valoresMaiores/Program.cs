using System;

namespace valoresMaiores
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Digite o primeiro número!!!");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora o segundo!!!");
            n2 = double.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O primeiro número é o maior!!!");
            } else if (n2 > n1)
            {
                Console.WriteLine("O segundo número é o maior!!!");
            }
        }
    }
}
