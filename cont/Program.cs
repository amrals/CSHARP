using System;

namespace cont
{
    class Program
    {
        static void Main(string[] args)
        {
            int aumento = 0;//essa variável representa o valor a ser acrescentado.

            Console.WriteLine("Hello World!");

            do//o console irá fazer o comando aplicado abaixo.
            {
                Console.WriteLine("O valor atual do aumento é de:" + aumento);//mensagem exibida para visualizar o valor da variável.
                aumento += 50;//será acrescentado à variável 50 unidades.

            } while (aumento < 500);//enquanto o valor variável for inferior à 500, o console repetirá o comando com o "do".
        }
    }
}
