﻿using System;


namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string separarAtividade = ("\n_________________________________________\n");
            
            string frase = Console.ReadLine();
            string y = Console.ReadLine();
            string x = Console.ReadLine();

            string s = Console.ReadLine();

            string[] v = s.Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou: " + frase);
            Console.WriteLine(y);
            Console.WriteLine(x);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.Write(separarAtividade);

            int n1 = 35;
            char ch = 'F';
            double n2 = 4.32;

            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);

            Console.Write(separarAtividade);    // */

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu genero: ");
            char sexo = char.Parse(Console.ReadLine());
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

            Console.Write(separarAtividade);
        }
    }
}
