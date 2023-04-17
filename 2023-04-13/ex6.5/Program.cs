string[] lista = new string[10];
for (var i = 0; i < lista.Length; i++)
{
    Console.WriteLine($"Digite o nome");
    lista[i] = Console.ReadLine();
}
Console.WriteLine($"Digite o nome para buscar");
string busca = Console.ReadLine();

if (lista.Contains(busca))
{
    Console.WriteLine($"ACHEI MISERÁVEL");
}
else
{
    Console.WriteLine($"ACHEI NÃO");
    
}