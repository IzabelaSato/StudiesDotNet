using System;

namespace Diferenca_do_Produto
{
    class DiferencaProduto// Exercicio 3 Udemy
    {
        static void Main(string[] args) 
        {
            int n1, n2, n3, n4;
            int diferencaProduto;

            Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o quarto número: ");
            n4 = int.Parse(Console.ReadLine()); 

            diferencaProduto = ((n1 * n2) - (n3 * n4));

            Console.WriteLine("A diferença entre os produtos é: " + diferencaProduto);
        }
    }
}
