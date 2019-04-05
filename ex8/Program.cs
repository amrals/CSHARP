using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // int length = 100;
            Console.WriteLine("quantas stars de altura?");
            // length = int.Parse(Console.ReadLine());
            int num = 0;

            for (int i = 0; i <= 100; i++)
            {
                num += 1;

                if ((num % 4) == 0)
                {
                    Console.WriteLine("pi");
                } else
                {
                    Console.WriteLine(num);
                }
                
            }
        }
    }
}
