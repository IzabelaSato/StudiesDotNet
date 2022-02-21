using System;

namespace While_Senha
{
    class Program// me ajuda a parar o executável
    {
        static void Main(string[] args)
        {
            int senha = 0;

            while (senha != 2002)
            {              
                Console.Write("Senha: ");
                senha = int.Parse(Console.ReadLine());
                if (senha == 2002)
                {
                    Console.WriteLine("Acesso permitido");
                }
                else
                {
                    Console.WriteLine("Senha Inválida");
                }
            }
        }
    }
}
