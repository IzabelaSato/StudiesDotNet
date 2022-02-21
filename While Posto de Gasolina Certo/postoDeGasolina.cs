using System;

namespace While_Posto_de_Gasolina_Certo
{
    class postoDeGasolina
    {
        static void Main(string[] args)// depois preciso de ajuda para mudar um detalhe
        {
            Console.WriteLine("Posto de Gasolina do Momiji");
            Console.WriteLine("\nPesquisa sobre a preferencia dos clientes ");
            Console.WriteLine("\nDigite as opções a seguir: ");
            Console.WriteLine("Caso não queira participar da pesquisa clique no numero 4 ");

            int numero = 0;

            while (numero!=4)
            {
                Console.WriteLine("1- Alcool");
                Console.WriteLine("2- Gasolina");
                Console.WriteLine("3- Diesel");
                Console.WriteLine("4- Sair");
                numero = int.Parse(Console.ReadLine());

                if (numero == 1)
                {
                    Console.WriteLine("Sua preferencia é por Alcool");
                }
                if (numero == 2)
                {
                    Console.WriteLine("Sua preferencia é por Gasolina");
                }
                if (numero == 3)
                {
                    Console.WriteLine("Sua preferencia é por Diesel");
                }
            }

            if (numero == 4)
            {
                Console.Write("Obrigado e volte sempre");
            }
        }
    }
}
