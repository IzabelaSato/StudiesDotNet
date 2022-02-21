using System;

namespace If_e_Else_Positivo_e_Negativo
{
    class positivoNegativo// EXERCICIO 1 DA LISTA 2 DA UDEMY
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro, podendo ser positivo e negativo");// DÊ PREFERENCIA POR USAR SOMENTE O IF

            int positivoNegativo = int.Parse(Console.ReadLine());

            if (positivoNegativo >= 0)
            {
                Console.WriteLine("Este numero é POSITIVO");
            }
            if(positivoNegativo <= -1)
            {
                Console.WriteLine("Este numero é NEGATIVO");
            }
        }
    }
}
