using System;

namespace If_e_Else_Imposto 
{
    class Imposto// udemy exercicio 8 apostila 2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCalculo de imposto do País LISARB");

            double salario;

            Console.Write("Digite seu salário: R$ ");
            salario = double.Parse(Console.ReadLine());

            if (salario >= 0.00 && salario <= 2000.00) 
            {
                Console.WriteLine("Você esta isento de tributação");
            }
            if (salario > 2000.01 && salario <=3000.00 )
            {
                Console.WriteLine("Você pagará de imposto um valor total de R$" + ((salario * 8) / 100));
            }

            if (salario >=3000.01 && salario <= 4500.00)
            {
                Console.WriteLine("Você pagará de imposto um valor total de R$" + ((salario * 18)/ 100));
            }
            if(salario >= 4500.01 )
            {
                Console.WriteLine("Você pagará de imposto um valor total de R$" + ((salario * 28) / 100));
            }
        }
    }
}
