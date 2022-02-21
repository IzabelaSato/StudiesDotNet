using System;

namespace valorPeca// exercicio udemy 5
{
    class valorPeca
    {
        static void Main(string[] args)
        {
            int codigo1, numeroPeca1, codigo2, numeroPeca2;
            float valorUnitario1, valorUnitario2, total;

            Console.Write("Digite o código da peça 1: ");
            codigo1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade da peça 1: ");
            numeroPeca1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da peça 1: ");
            valorUnitario1 = float.Parse(Console.ReadLine());

            Console.Write("\nDigite o código da peça 2: ");
            codigo2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade da peça 2: ");
            numeroPeca2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da peça 2: ");
            valorUnitario2 = float.Parse(Console.ReadLine());

            total = (numeroPeca1*valorUnitario1) + (numeroPeca2*valorUnitario2);

            Console.WriteLine("\nA soma das peças "+codigo1 +" e "+codigo2+" é igual a R$"+total.ToString("F2")+" reais");
        }
    }
}
