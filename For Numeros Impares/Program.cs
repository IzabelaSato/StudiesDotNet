Console.Write("Digite um numero qualquer entre 1 e 1000: ");

int x = int.Parse(Console.ReadLine());

if (x >= 1 && x <= 1000)
{
    Console.WriteLine("Os numeros impares são:");
    for (int i = 1; i <= x; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}
else
{
    Console.WriteLine("Digite um valor válido");
}