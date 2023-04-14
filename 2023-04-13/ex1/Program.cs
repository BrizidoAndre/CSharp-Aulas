Console.WriteLine($"Por favor, digite o ano em que você nasceu");
int ano = int.Parse(Console.ReadLine());

if ( DateTime.Now.Year - ano < 18)
{
    Console.WriteLine($"Você não pode votar ainda :(");
}
else
{
    Console.WriteLine($"Você pode votar agora :)");
}
 