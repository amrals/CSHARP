using System;

namespace quantIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            int masc = 0;
            int femin = 0;

            Console.WriteLine("Me dê a idade!!!");
            
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite seu sexo");
                sexo = Console.ReadLine().ToLower();

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
                    i--;
                    Console.WriteLine("Digite um valor válido");
                }
            }

                Console.WriteLine("San "+masc+" hombres");
                Console.WriteLine("San "+femin+" mujeres");
        
        }
        }
    
    }
