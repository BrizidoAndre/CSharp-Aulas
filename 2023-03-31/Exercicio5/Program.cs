Console.WriteLine($"Por favor, digite o caractere a ser informado:");
string a =Console.ReadLine().ToLower();
if (a == "a" || a == "e" || a == "i" || a == "o" || a == "u")
{
    Console.WriteLine($"Seu caractere é uma vogal!");
}
else if (a == "")
{
    Console.WriteLine($"Nenhum caractere nao é nada! >:(");
}
else
{
    Console.WriteLine($"Seu caractere é uma consoante");
}