using System;

namespace media50
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome1 = new string[10];
            string[] nome2 = new string[10];
            float[] nota1 = new float[10];
            float[] nota2 = new float[10];
            float[] media = new float[10];
            string[] situacao = new string[10];

            Console.WriteLine("Bem vindo ao Boletim Digital!!!");

            for (int i = 0; i < 2; i++)
            {
                System.Console.WriteLine("---------------------");
                System.Console.WriteLine("Digite seu primeiro nome");
                nome1[i] = Console.ReadLine();
                System.Console.WriteLine("Digite seu sobrenome");
                nome2[i] = Console.ReadLine();
                System.Console.WriteLine("Digite sua primeira nota");
                nota1[i] = float.Parse(Console.ReadLine());
                System.Console.WriteLine("Digite sua segunda nota");
                nota2[i] = float.Parse(Console.ReadLine());

                media[i] = (nota1[i] + nota2[i]) / 2;

                if (media[i] >= 50)
                {
                    situacao[i] = "APROVADO";
                } else
                {
                    situacao[i] = "REPROVADO";
                }
            }

            for (int a = 0; a < 2; a++)
            {
                
                System.Console.WriteLine($"------------------------\n Aluno: {nome1[a]} {nome2[a]} \n Média: {media[a]} \n Situação: {situacao[a]} \n------------------------");
            }

            
        }
    }
}
