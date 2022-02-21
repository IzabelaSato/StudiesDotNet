
Console.WriteLine("Você sabe a Soma dos numeros inteiros de 1 a 100? Eu sei!");

int numeros, total = 0;

Console.WriteLine("Digite o numero 1");
numeros = int.Parse(Console.ReadLine());

while (numeros <= 100)
{
    total += numeros;
    numeros++;
}

Console.Write("Total 0 a 100 = " + total);