using System;

namespace ips
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade = 0;
            double peso = 0;
            string sexo;
            int masc = 0;
            int femin = 0;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite sua idade!!!");
                idade = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu peso!!!");
                peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu sexo rs!!!");
                sexo = Console.ReadLine();
                    if (sexo.Equals("m"))
                    {
                        masc++;
                    }
                    else if (sexo.Equals("f"))
                    {
                        femin++;
                    }
                    else
                    {
                        Console.WriteLine("Digite um valor válido");
                    }
            }

                Console.WriteLine("Son "+masc+" hombres");
                Console.WriteLine("Son "+femin+" mujeres");

                Console.WriteLine("Média da idade de todos");
                Console.WriteLine((idade+idade)/2);

                Console.WriteLine("Média do peso de todos");
                Console.WriteLine((peso+peso)/2);
        }
    }
}
