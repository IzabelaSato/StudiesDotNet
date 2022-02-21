using System;

namespace While_Posto_de_Gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Posto de Gasolina do Momiji");
            Console.WriteLine("Pesquisa sobre a preferencia dos clientes ");
            Console.WriteLine("Digite as opções a seguir: ");

            int numero;

            Console.WriteLine("1- Alcool");
            Console.WriteLine("2- Gasolina");
            Console.WriteLine("3- Diesel");
            Console.WriteLine("4- Sair x ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (numero == 1)
                {
                    Console.Write("Sua preferencia é por ALCOOL");
                    numero = int.Parse(Console.ReadLine());
                }
                if (numero == 2)
                {
                    Console.Write("Sua preferencia é por GASOLINA ");
                    numero = int.Parse(Console.ReadLine());
                }
                if (numero == 3)
                {
                    Console.Write("Sua preferencia é por DIESEL");
                    numero = int.Parse(Console.ReadLine());
                }

                if (numero == 4)
                {
                    Console.Write("SAIR");
                    numero = int.Parse(Console.ReadLine());
                }


            }

        }
    }
