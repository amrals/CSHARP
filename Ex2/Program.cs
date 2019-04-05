using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a média");

            float nota1 = 8;
            float nota2 = 8;
            float nota3 = 8;
            int faltas = 26;

            float soma;

            Console.WriteLine("Digite a primeira nota");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota");
            nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas");
            faltas = int.Parse(Console.ReadLine());

            soma = nota1 + nota2 + nota3;

            double media = soma/3;

            if (media < 5 || faltas > 25)
            {
                Console.WriteLine("Aluno Reprovado");
            } else if (media < 9)
            {
                Console.WriteLine("Aluno Aprovado");
            } else
            {
                Console.WriteLine("É isso ai, jovem");
            }
        }
    }
}
