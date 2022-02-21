using System;

namespace Area
{
    class area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos Calcular? Vem comigo que eu te ajudo!");
            Console.WriteLine("Lembre-se sempre de apertar o ENTER após cada resposta ;)");

            float areaTriangulo, baseTriangulo, alturaTriangulo, pi = 3.14159f, raioCirculo, areaCirculo, 
                baseMaiorTrapezio, baseMenorTrapezio, alturaTrapezio, areaTrapezio, areaQuadrado, ladoQuadrado;

            Console.WriteLine("\nPrimeiro coloque as informações sobre o Triangulo Retangulo:");
            Console.Write("Altura: ");
            alturaTriangulo = float.Parse(Console.ReadLine());
            Console.Write("base: ");
            baseTriangulo = float.Parse(Console.ReadLine());
            areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;


            Console.WriteLine("\nAgora digite a informação sobre o Círculo...");
            Console.Write("Raio do círculo: ");
            raioCirculo = float.Parse(Console.ReadLine());
            areaCirculo = pi * (raioCirculo * raioCirculo);

            Console.WriteLine("\nNão quero saber de reclamações, pois estamos na metade do exercício.. hahaha");

            Console.WriteLine("\nAgora digite as informações sobre o trapézio... ");
            Console.Write("Base maior: ");
            baseMaiorTrapezio = float.Parse(Console.ReadLine());
            Console.Write("Base Menor: ");
            baseMenorTrapezio = float.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            alturaTrapezio = float.Parse(Console.ReadLine());
            areaTrapezio = (baseMaiorTrapezio + baseMenorTrapezio) * alturaTrapezio / 2;

            Console.WriteLine("\nPega o quadrado, mede ele por favor e me passa o valor...");
            Console.Write("lado: ");
            ladoQuadrado = float.Parse(Console.ReadLine());
            areaQuadrado = (ladoQuadrado * ladoQuadrado);

            Console.WriteLine("\nUfaa, esse é o ultimo, já nao aguento armazenar tantos números...");

            Console.WriteLine("\nMe passe as informações sobre o Retangulo...");

            float baseRetangulo, alturaRetangulo, areaRetangulo;
            Console.Write("Base: ");
            baseRetangulo = float.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            alturaRetangulo = float.Parse(Console.ReadLine());
            areaRetangulo = (baseRetangulo * alturaRetangulo);

            Console.WriteLine("\n... olha como eu calculo rapidão, você demoraria uma eternidade que eu sei...");
            Console.WriteLine("\nArea do triangulo: "+areaTriangulo);
            Console.WriteLine("Area do Circulo: "+ areaCirculo);
            Console.WriteLine("Area do trapezio: "+areaTrapezio);
            Console.WriteLine("Area do Quadrado: "+ areaQuadrado);
            Console.WriteLine("Area do Retangulo: "+ areaRetangulo);

            Console.WriteLine("\nViu.. nem foi difícil, o trabalho pesado ficou pra mim hahahahaha");
        }
    }
}
