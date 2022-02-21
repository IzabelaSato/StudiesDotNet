int area, largura = 1, comprimento;
bool sucesso;

Console.WriteLine("Calcular o metro quadrado\n");

while (largura != 0)
{
    Console.Write("Digite a larqura do que você deseja calcular: ");
    if (int.TryParse(Console.ReadLine(), out largura)) // largura = int.Parse(Console.ReadLine());    
    {
        if (largura > 0)
        {
            Console.Write("Digite a comprimento do que você deseja calcular: ");
            sucesso = int.TryParse(Console.ReadLine(), out comprimento); // comprimento = int.Parse(Console.ReadLine());            

            if (sucesso)
            {
                area = (largura * comprimento);
                Console.WriteLine("O total da área é: " + area + "\n");
            }
        }
    }
    else
    {
        Console.WriteLine("Valor inválido!\n");
        largura = 1; // pois o int.TryParse retorna ZERO caso ocorra algum erro
    }
}