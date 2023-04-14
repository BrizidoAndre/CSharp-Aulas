using System.Globalization;

static float CalculadorPreco(float dMaior, float dMenor, float preco, int litro)
{
    if (litro <= 20)
    {
        return (preco - (preco * dMenor)) * litro;
    }
    else
    {
        return (preco - (preco * dMaior)) * litro;
    }
}
float gPreco = 0;
float gMenor = 0;
float gMaior = 0;
Console.WriteLine(@$"
_______________________________________________________
Bem Vindo, digite o tipo de combustível que deseja:

G - Gasolina

A - Álcool
");
char combustivel = char.Parse(Console.ReadLine().ToLower());

switch (combustivel)
{
    case 'g':
        gPreco = 5.30F;
        gMenor = 0.03F;
        gMaior = 0.05F;
        break;
    case 'a':
        gPreco = 4.90F;
        gMenor = 0.03F;
        gMaior = 0.05F;
        break;
    default:
        while (combustivel != 'g' && combustivel != 'a')
        {
            Console.WriteLine($"Esse não é uma entrada válida por favor digite novamente");
            combustivel = char.Parse(Console.ReadLine());
            switch (combustivel)
            {
                case 'g':
                    gPreco = 5.30F;
                    gMenor = 0.03F;
                    gMaior = 0.05F;
                    break;
                case 'a':
                    gPreco = 4.90F;
                    gMenor = 0.03F;
                    gMaior = 0.05F;
                    break;
            }
        }
        break;
}
Console.WriteLine($"Agora digite quantos litros deseja");
int litro = int.Parse(Console.ReadLine());
Console.WriteLine($"O preço final é de:");
Console.WriteLine(Math.Round(CalculadorPreco(gMaior, gMenor, gPreco, litro),2).ToString("C", new CultureInfo("pt-BR")));