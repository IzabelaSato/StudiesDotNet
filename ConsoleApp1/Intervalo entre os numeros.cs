using System;

namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args)
        {
            int digiteNumero;

            Console.WriteLine("Digite um numero INTEIRO qualquer entre 0 e 100: ");
            digiteNumero = int.Parse(Console.ReadLine());           

            if (digiteNumero <= 25)
            {
                Console.WriteLine("Este numero esta no intervalo entre 0 e 25");
            }
            if (digiteNumero >= 26 && digiteNumero <= 50)
            {
                Console.WriteLine("Este numero esta no intervalo entre 25 e 50");
            }
            if (digiteNumero >= 51 && digiteNumero <= 75)
            {
                Console.WriteLine("Este numero esta no intervalo entre 50 e 75");
            }
            if (digiteNumero >=76)
            {
                Console.WriteLine("Fora do intervalo desejado");
            }


        }
    }
}
