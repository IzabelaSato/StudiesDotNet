
string produto = "";
//double valor = 0, total;
int quantidade = 0;

Console.WriteLine("Supermercado da Bella");
Console.WriteLine("Para finalizar precione a Tecla X");

while (produto != "x") 
{   
    Console.Write("Digite o nome do produto: ");
    produto = Console.ReadLine();

    if (produto != "x")
    {
        quantidade++;
    }
      

//    Console.Write("Digite o valor unitário do produto: R$");
//    valor = double.Parse(Console.ReadLine());
   
}
//total = valor++;
Console.WriteLine("Quantidade: " + quantidade);

/*Console.Write("Digite o nome do produto: ");
  produto = Console.ReadLine();

  Console.Write("Digite o valor unitário do produto: R$");
  valor = double.Parse(Console.ReadLine());

  Console.Write("Digite a quantidade: ");
  quantidade = int.Parse(Console.ReadLine());

  total = (valor * quantidade);
  Console.WriteLine("O valor total é R$ " + (double)total); */