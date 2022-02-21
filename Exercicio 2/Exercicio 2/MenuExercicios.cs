using System;

namespace Exercicio_2
{
    class MenuExercicios
    {
        private static void Soma()
        {
            int n1, n2, soma;
            Console.WriteLine("Digite um número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("A soma dos números " + n1 + " e " + n2 + " é igual a " + soma);
        }

        private static void Subtracao()
        {
            int n1, n2, sub;
            Console.WriteLine("Digite um número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            n2 = int.Parse(Console.ReadLine());
            sub = n1 - n2;
            Console.WriteLine("A subtração do número " + n1 + " por " + n2 + " é igual a " + sub);
        }

        static void Main(string[] args)
        {
            string opcaoUsuario;
            bool retornaMenu;

            do
            {
                Console.Clear();
                Console.WriteLine("Qual exercício deseja acessar?\n");
                Console.WriteLine("1- Somar dois valores");
                Console.WriteLine("2- Subtrair dois valores");
                Console.WriteLine("3- Área de um círculo");
                Console.WriteLine("X- Sair");
                Console.WriteLine("");

                opcaoUsuario = Console.ReadLine();
                retornaMenu = true;
                Console.Clear();

                switch (opcaoUsuario)
                {
                    case "1":                     
                        Soma();
                        break;
                    case "2":
                        Subtracao();
                        break;
                    case "3":
                        //TODO: calcular media geral
                        break;
                    default:
                        retornaMenu = false;
                        if (opcaoUsuario.ToUpper() != "X")
                        {
                            Console.WriteLine("Opção inválida!");
                            Console.ReadLine();
                        }
                        // throw new ArgumentOutOfRangeException();
                        break;
                }
                if (retornaMenu)
                {
                    Console.WriteLine("\n... retornando ao menu principal");
                    Console.ReadLine();
                }

            } while (opcaoUsuario.ToUpper() != "X");
        }
    }
}