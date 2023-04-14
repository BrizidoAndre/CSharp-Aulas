Console.WriteLine(@$"Vamos ver se seu triângulo é equilátero, isóceles ou escaleno.
Por favor digite a medida de um lado do seu triângulo apenas com números");
float a = float.Parse(Console.ReadLine());

Console.WriteLine($"Agora digite a segunda medida do seu triângulo, novamente apenas com números");
float b = float.Parse(Console.ReadLine());

Console.WriteLine($"Agora digite a ultima medida do seu triângulo, novamente apenas com números");
float c = float.Parse(Console.ReadLine());

if (a == b && b == c)
{
    Console.WriteLine($"Seu triângulo é equilátero.");
}

else if (a != b && b != c && a != c)
{
    Console.WriteLine($"Seu triângulo é escaleno");
}
else
{
    Console.WriteLine($"Seu triângulo é isóceles");
    
}