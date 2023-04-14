float[] lista = new float[15];

for (var i = 0; i < lista.Length; i++)
{
    Console.WriteLine($"Por favor digite o {i+1}º da lista");
    lista[i] = float.Parse(Console.ReadLine());
}
Console.WriteLine($"Agora a lista aparecerá invertida!!!");
for (var i = 14; i >= 0; i--)
{
    Console.WriteLine(lista[i]);
}