using System;

namespace multiplos4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int tamanhoTriangulo = int.Parse(Console.ReadLine());
            string estrela = "";

            for (int i = 0; i < tamanhoTriangulo; i++)
            {
                estrela += "*";
                Console.WriteLine(estrela);
            }
        }
    }
}
