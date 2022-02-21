using System;
//using System.Globalization;

namespace Udemy_1
{
    class somaInteiros
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 30;
            int n3 = (-30);
            int n4 = 0;
            int soma = n1 + n2;
            int soma2 = n1 + n3;
            int soma3 = n4 + n4;
          
            Console.WriteLine($"\nPLACEHOLDER: A soma de {n1} e {n2} é igual a {soma}");
            Console.WriteLine("INTERPOLAÇÃO:A soma de {0} e {1} é igual a {2}", n1, n2, soma);
            Console.WriteLine("CONCATENAÇÃO:A soma de " + n1 + " e " + n2 + " é igual a " + soma);

            Console.WriteLine($"\nPLACEHOLDER: A soma de {n1} e {n3} é igual a {n1+n3}");
            Console.WriteLine("INTERPOLAÇÃO:A soma de {0} e {1} é igual a {2}", n1, n3, soma2);
            Console.WriteLine("CONCATENAÇÃO:A soma de " + n1 + " e " + n3 + " é igual a " + soma2);

            Console.WriteLine($"\nPLACEHOLDER: A soma de {n4} e {n4} é igual a {soma3}");
            Console.WriteLine("INTERPOLAÇÃO:A soma de {0} e {1} é igual a {2}", n4, n4, soma3);
            Console.WriteLine("CONCATENAÇÃO:A soma de " + n4 + " e " + n4 + " é igual a " + soma3);
           








        }
    }
}
 