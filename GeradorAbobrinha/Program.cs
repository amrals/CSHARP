using System;

namespace GeradorAbobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve uma palavra aí meu consagrado!!!");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFrase = 5;

            string[] palavrasUsuario = new string[maxPalavrasUsuario];

            for (int i = 0; maxPalavrasUsuario > 0 ; i++)
            {
                palavrasUsuario[i] = Console.ReadLine();

                if (--maxPalavrasUsuario != 0)
                {
                    System.Console.WriteLine($"Faltam {maxPalavrasUsuario}. Digite mais uma bb!!!!");
                }else
                {
                    System.Console.WriteLine("Valeu jovem! Agora deixa cmg rs");
                }
            }
            string[,] matrizPalavras = {
                                            {"bode","","pia","","cozinha",""},
                                            {"selva","","olivia","","costume","tigrao"},
                                            {"rs","idiota","agente","destruição","cabelo","estiloso"},
                                            {"tchutchuca","luffy","ihiii","frank","","franky"},
                                            {"caramba","rusbé","distopia","","doidera","verdade"}
                                        };
            for (int i = 0; i < matrizPalavras.GetLength(0); i++)
            {
                for (int j = 0; j < matrizPalavras.GetLength(0); j++)
                {
                    if ("".Equals(matrizPalavras[i,j]))
                    {
                        matrizPalavras[i,j] = palavrasUsuario[i];
                    }
                }
            }
            string frase = "";

            Random r = new Random();
            for (int i = 0; i < maxPalavrasFrase; i++)
            {
                frase += matrizPalavras[r.Next(matrizPalavras.GetLength(0)),r.Next(matrizPalavras.GetLength(0))] + " ";
            }
            System.Console.WriteLine("Minha frase é: \n"+ frase);
        }
    }
}
