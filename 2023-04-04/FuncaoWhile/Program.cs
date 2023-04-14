// Variavel TRUE 
bool teste = true;
// Esse While ira repetir enquanto o teste for TRUE
// while (teste)
// {
//     Console.WriteLine($"Qual a idade do pericles");
//     int idade = int.Parse(Console.ReadLine());
//     // Esse if transforma a variavel que repete em FALSE quando o usuario acertar o valor, parando assim a repeticao
//     if (idade == 53)
//     {
//         teste = false;
//     }

// }
do
{
    Console.WriteLine($"Qual a idade do pericles");
    int idade = int.Parse(Console.ReadLine());
    if (idade == 53)
    {
        teste = false;
    }
} while (teste);