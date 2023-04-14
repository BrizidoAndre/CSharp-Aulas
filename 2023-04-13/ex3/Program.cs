using System.Globalization;

float desconto = 0;
Console.WriteLine($"Por favor digite o nome do produto:");
string produto = Console.ReadLine();

Console.WriteLine($"Quantas unidades foram compradas:");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine($"Por fim, qual o preço unitário");
float preço = (float) Math.Round(float.Parse(Console.ReadLine()),2);

if (quantidade <= 5)
{
    desconto = 0.02F;
}
else if (quantidade > 5 && quantidade <= 10)
{
    desconto = 0.03F;
}
else
{
    desconto = 0.05F;
}
Console.WriteLine(@$"Segue as informações:
Nome: {produto}
Quantidade: {quantidade}");
Console.Write("Preço:");
Console.WriteLine((preço * quantidade).ToString("C", new CultureInfo("pt-BR")));
Console.Write($"Desconto: ");
Console.WriteLine((preço * quantidade * desconto).ToString("C", new CultureInfo("pt-BR")));
Console.Write($"Total a Pagar: ");
Console.WriteLine(((preço * quantidade) - (preço * quantidade * desconto)).ToString("C", new CultureInfo("pt-BR")));