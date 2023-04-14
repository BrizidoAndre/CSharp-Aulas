// Condicional Simples 
// Apenas executa uma ou mais ações se a condição for verdadeira
// Condição se o sol é true
// bool nublado = true;

// if (nublado)
// {
//     Console.WriteLine($"Dia lindo");
    
// }

// Condição Composta
// bool sol = true;
// bool folga = false;

// if (sol && folga)
// {
//     Console.WriteLine($"Vou para a praia");
    
// }
// else{
//     Console.WriteLine($"Vou dormir zzzz");
    
// }


// Condicional Encadeada

//Maior ou igual a 18 = pode entrar na festa
//Maior de 16, menor de 18 = pode entrar com responsável
//Menor do que 16 = não entra

Console.WriteLine($"Digite sua idade");

byte idade = byte.Parse(Console.ReadLine());

if(idade >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Pode entrar na festa");
    Console.ResetColor();
}
else if (idade > 16)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Pode entrar na festa com a Mamãe!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Não vai entrar não larápio");
    Console.ResetColor();
}