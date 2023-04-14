int [] dobro = new int [5];
Console.WriteLine($"Leitura para ver o dobro de múltiplos números");
for (var i = 0; i < dobro.Length; i++)
{
    Console.WriteLine($"Por favor digite o {i + 1}º número");
    dobro [i] = int.Parse(Console.ReadLine());
}
foreach (int item in dobro)
{
    Console.WriteLine($"o dobro de {item} é {item + item}");
    
}