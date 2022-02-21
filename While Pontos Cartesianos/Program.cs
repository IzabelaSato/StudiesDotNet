using System;

namespace While_Pontos_Cartesianos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos saber em qual Quadrante está os pontos cartesianos");

            int ponto1 = 1, ponto2 = 1;            

            while (ponto1 != 0 && ponto2 != 0)
            {
                Console.Write("Digite o primeiro ponto: ");
                ponto1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo ponto: ");
                ponto2 = int.Parse(Console.ReadLine());

                if (ponto1 >= +1 && ponto2 >= +1)
                {
                    Console.WriteLine("Pertence ao quadrante 1");
                }
                if (ponto1 <= -1 && ponto2 >= +1)
                {
                    Console.WriteLine("Pertence ao quadrante 2");
                }
                if (ponto1 <= -1 && ponto2 <= -1)
                {
                    Console.WriteLine("Pertence ao quadrante 3");
                }
                if (ponto1 >= +1 && ponto2 <= -1)
                {
                    Console.WriteLine("Pertence ao quadrante 4");
                }
            }
        }
    }
}
