Console.WriteLine(@$"Boa tarde!
Aqui viemos calcular sua idade em minutos, horas, dias e meses!
Então vamos começar?");
Console.WriteLine($"Qual sua idade?");
int idade = int.Parse(Console.ReadLine());
int idademeses = idade * 12;
int idadedias = idade * 365;
int idadehoras = idadedias * 24;
int idademinutos = idadehoras * 60;
Console.WriteLine(@$"Sua idade é de {idade} anos
Portanto você tem:
{idademinutos} Minutos vividos
{idadehoras} Horas vividas
{idadedias} Dias vividos e
{idademeses} meses vividos.
");

// int idaderest = 77 - idade;
// int idademesesrest = (77 * 12) - idademeses;
// int idadediasrest = (77 * 365) - idadedias;
// int idadehorasrest = (idadediasrest * 24) - idadehoras;
// int idademinutosrest = (idadehorasrest * 60) - idademinutos;

// Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine(@$"
// Lhe restam:
// {idademinutosrest} Minutos de vida
// {idadehorasrest} Horas de vida
// {idadediasrest} Dias de vida e
// {idademesesrest} meses de vida.
// ");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrigado por usar nossos serviços!");
Console.ResetColor();

