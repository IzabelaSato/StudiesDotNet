using System;
using System.Globalization;

namespace Area_circulo
{
    class AreaCirculo // Udemy Exercicio 2, acrescentei para imprimir com ponto ao invés de virgula
    {
        static void Main(string[] args)
        {
            float pi = 3.14159f, digiteNumero, raioDoCirculo;

            Console.WriteLine("Digite raio do círculo: ");
            digiteNumero = float.Parse(Console.ReadLine());
            raioDoCirculo = pi * (digiteNumero * digiteNumero);

            Console.WriteLine($"INTERPOLAÇÃO: A área do círculo é: {raioDoCirculo:F4}");// F4 é igual a 4 casas decimais
            Console.WriteLine("PLACEHOLDER: A área do círculo é: {0:F4}", raioDoCirculo);// F4 é igual a 4 casas decimais
            Console.WriteLine("CONCATENAÇÃO: A área do círculo é: " + raioDoCirculo.ToString("F4", CultureInfo.InvariantCulture)); // utiliza o ponto como separador decimal e só pode ser usado na concatenação
        }
    }
}
