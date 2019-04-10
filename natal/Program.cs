using System;

namespace natal
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            for (int i = 0; i < 3; i++)
            {
                a  = "";
                for (int j = 0; j < 5; j++)
                {
                    a+= "@";
                    Console.WriteLine(a);

                }//fim for 2

            }//fim for1
        }
    }
}
