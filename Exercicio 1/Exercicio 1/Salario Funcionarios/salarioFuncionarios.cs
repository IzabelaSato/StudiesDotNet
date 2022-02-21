using System;

namespace Salario_Funcionarios // Exercício Udemy 04
{
    class salarioFuncionarios
    {
        static void Main(string[] args)
        {
            string nomeFuncionario;
            int quantiddFuncionarios;
            float hrsTrabalhadas, salario, valorHrTrabalhada;

            Console.Write("Digite seu nome: ");
            nomeFuncionario = Console.ReadLine();
            Console.Write("Digite as horas trabalhadas ");
            hrsTrabalhadas = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor de uma hora trabalhada: ");
            valorHrTrabalhada = float.Parse(Console.ReadLine());

            salario = hrsTrabalhadas * valorHrTrabalhada;

            Console.WriteLine(nomeFuncionario+ "o valor que você receberá referente ao mês de Janeiro de 2022 é de: R$ "+salario.ToString ("F2")+ " reais");

        }
    }
}
