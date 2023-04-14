Console.WriteLine($"Qual sua data de nascimento");

int nascimento = int.Parse(Console.ReadLine());
int agora = DateTime.Now.Year;
int idade = (agora - nascimento);
int idadesemanas = (idade * 52);

Console.WriteLine($"Agora é o ano de {agora} portanto você tem {idade} anos e {idadesemanas} semanas");

Console.ForegroundColor = ConsoleColor.Magenta;

Console.WriteLine($"Fim de operação");

Console.ResetColor();
