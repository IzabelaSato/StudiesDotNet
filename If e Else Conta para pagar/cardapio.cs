using System;

namespace If_e_Else_Conta_para_pagar
{
    class cardapio
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cardápio Dogão do Dino");

            double cachorroQuente, xSalada, xBacon, torrada, refri, codigo;
            int quantidade;

            cachorroQuente = 4.50;
            xSalada = 4.50;
            xBacon = 5.00;
            torrada = 2.00;
            refri = 1.50;

            Console.WriteLine("Digite o código do produto: ");
            codigo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade solicitada: ");
            quantidade = int.Parse(Console.ReadLine());


            if (codigo == 1)
            {
                Console.WriteLine("Valor total: R$ " + (double) cachorroQuente*quantidade);
            }

            if (codigo == 2)
            {
                Console.WriteLine("Valor total: R$ " + (double) xSalada * quantidade);
            }
            if (codigo == 3)
            {
                Console.WriteLine("Valor total: R$ " + (double) xBacon * quantidade);
            }
            if (codigo == 4)
            {
                Console.WriteLine("Valor total: R$ " + (double) torrada * quantidade);
            }
            if (codigo == 5)
            {
                Console.WriteLine("Valor total: R$ " + (double) refri * quantidade);
            }
            if (codigo >= 6)
            {
                Console.WriteLine("Codigo Inválido, favor digitar de 1 a 5 ");
            }

        }

    }
}
