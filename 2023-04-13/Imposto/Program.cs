using System.Globalization;

static float Imposto (float a)
{
    if (a <= 1500)
    {
        return 0;
    }
    else if (a > 1500 && a <= 3500)
    {
        return (a * 0.20F);
    }
    else if (a > 3500 && a <= 6000)
    {
        return (a * 0.25F);
    }
    else
    {
        return(a * 0.35F);
    }
}
Console.WriteLine($"Aqui vamos calcular seu imposto, por favor digite seu salário");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine(@$"
Salário: {Math.Round(salario,2).ToString("C", new CultureInfo("pt-BR"))}
Imposto: R${Math.Round(Imposto(salario), 2)}");