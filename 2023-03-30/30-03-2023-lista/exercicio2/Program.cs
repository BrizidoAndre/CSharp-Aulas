Console.WriteLine(@$"Aqui veremos se o seu time ganhou o Jogo!
Por favor digite a pontuação do seu oponente:");

byte adversario = byte.Parse(Console.ReadLine());

Console.WriteLine($"Agora digite a pontuação do seu time:");

byte time = byte.Parse(Console.ReadLine());

if (adversario==time)
{
    Console.WriteLine($"Foi empate :/");
}
else if (adversario > time)
{
    Console.WriteLine($"Seu time perdeu :(");
    
}
else
{
    Console.WriteLine($"Seu time Ganhou :)");
    
}