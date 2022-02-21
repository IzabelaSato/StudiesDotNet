using System;

namespace If_e_Else_Multilplos
{
    class Multiplos // exercicio Udemy 03 da apostila 2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPara essa atividade preciso que você digite dois numeros sempre do MENOR PARA O MAIOR");

            int menor, maior;
            int restoDaDivisão;
            double x;
            Console.WriteLine("Digite um numero inteiro MENOR");
            menor= int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite um numero inteiro MAIOR");
            maior = int.Parse(Console.ReadLine());

            restoDaDivisão = (maior % menor);
            x = (double) maior / menor;// tem que colocar double para aparecer o calculo com virgula

            Console.WriteLine(x);
            Console.WriteLine(restoDaDivisão);

            if (restoDaDivisão == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            if (restoDaDivisão != 0)
            {
                Console.WriteLine("Não são Multiplos");
            }



        }
    }
}
