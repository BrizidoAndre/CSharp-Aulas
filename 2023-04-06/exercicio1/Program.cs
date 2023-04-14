float nota = 0;
do
{
Console.WriteLine($"Por favor, digite uma nota de zero a dez");
nota = (float) Math.Round(float.Parse(Console.ReadLine()), 2);    
} while (nota > 10 || nota < 0);
Console.WriteLine($"Sua nota e {nota}");

