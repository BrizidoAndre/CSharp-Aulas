// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.
Console.WriteLine($"Bem vindo! Por favor digite o dia em que você nasceu.");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine($"Agora digite o mês que você nasceu.");
int mes = int.Parse(Console.ReadLine());
Console.WriteLine($"Por fim digite o ano que você nasceu.");
int ano = int.Parse(Console.ReadLine());

if (dia > 31)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Não é possível existir um dia acima de 31!");
    Console.ResetColor();
}
if (mes > 12)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Não é possível existir um mês acima de 12!");
    Console.ResetColor();
}
if (ano > 2013)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Você não é um viajante do futuro!");
    Console.ResetColor();
}
else
{
    Console.WriteLine($"Bem... Você nasceu no dia {dia} no mês {mes} do ano {ano}");
    
}
