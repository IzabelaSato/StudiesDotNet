using System;

namespace If_e_Else
{
    class Program // estrutura composta
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o numero inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("Este numero é Par!");// a % significa RESTO DA DIVISÃO
            }
            else {
                Console.WriteLine("Este numero é Impar!");
            }
        }
    }
}
