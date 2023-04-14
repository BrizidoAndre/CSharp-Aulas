Console.WriteLine("Por favor, digite a Nota 1 do aluno");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Por favor, digite a Nota 2 do aluno");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Por favor, digite a Nota 3 do aluno");
float nota3 = float.Parse(Console.ReadLine());

Console.WriteLine("Por favor, digite a Nota 4 do aluno");
float nota4 = float.Parse(Console.ReadLine());

Console.WriteLine("Por favor, digite a Nota 5 do aluno");
float nota5 = float.Parse(Console.ReadLine());

float notamedia = (nota1+nota2+nota3+nota4+nota5)/5;

Console.WriteLine($"A média do seu aluno é de {notamedia}");

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine($"Obrigado por usar nossos serviços!");
Console.ResetColor();

