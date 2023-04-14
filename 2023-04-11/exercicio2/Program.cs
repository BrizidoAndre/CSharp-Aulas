string[] nomes = new string[5];
int[] idades = new int[5];

for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Por favor digite o {i + 1}º nome");
    nomes[i] = Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"Nome registrado!");
    Console.ResetColor();

    Console.WriteLine($"Agora digite a {i + 1}ª idade");
    idades[i] = int.Parse(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Idade registrada!");
    Console.ResetColor();
}
Console.WriteLine($"Segue a lista:");

for (var i = 0; i < 5; i++)
{
    Console.WriteLine(@$"
{i + 1})");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(@$"
Nome: {nomes[i]}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(@$"
Idade: {idades[i]}");
    Console.ResetColor();

}
Console.ResetColor();