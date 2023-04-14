float[] lista = new float [10];

for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"Por favor digite o {i + 1}º número");
    lista[i] = float.Parse(Console.ReadLine());
}
Console.WriteLine($"O maior número da lista é:");
Console.WriteLine(lista.Max());
Console.WriteLine($"O menor número da lista é:");
Console.WriteLine(lista.Min());