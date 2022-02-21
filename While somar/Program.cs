int numeros = 0, resultado = 0;

Console.WriteLine("Digite 3  numeros eleatórios de 0 a 100");
numeros = int.Parse(Console.ReadLine());


resultado = 1; 



for (numeros = 0; numeros != 0; resultado++ )
{
    Console.WriteLine("valor #{0}:", resultado);
    numeros= int.Parse(Console.ReadLine());
    numeros += resultado;
}
Console.WriteLine("Soma dos 3 numeros é "+ resultado);
