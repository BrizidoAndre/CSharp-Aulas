// Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
// "Telefonou para a vítima?"
// "Esteve no local do crime?"
// "Mora perto da vítima?"
// "Devia para a vítima?"
// "Já trabalhou com a vítima?
int culpa = 0;

Console.WriteLine(@$"Voçê agora está prestes a seguir uma série de perguntas das quais não poderá mentir.
Temos ao seu lado um detector de mentiras que indicará quando o nível de sua pressão subir e mostrará quando estiver mentindo.
Para cada mentira dita, um membro seu será cortado e dado aos cachorros.

Vamos seguir com as perguntas:
Telefonou para a vítima?");
string r1 = Console.ReadLine().ToLower();
if (r1 == "sim")
{
    culpa ++;
}

Console.WriteLine($"Esteve no local do crime?");
string r2 = Console.ReadLine().ToLower();
if (r2 == "sim")
{
    culpa +=1;
}

Console.WriteLine($"Mora perto da vítima?");
string r3 = Console.ReadLine().ToLower();
if (r3 == "sim")
{
    culpa +=1;
}

Console.WriteLine($"Devia para a vítima?");
string r4 = Console.ReadLine().ToLower();
if (r4 == "sim")
{
    culpa +=1;
}

Console.WriteLine($"Já trabalhou com a vítima?");
string r5 = Console.ReadLine().ToLower();
if (r5 == "sim")


{
    culpa +=1;
}
if (culpa < 2)
{
    Console.WriteLine($"Você está classificado como Inocente.");
    
}
else if (culpa == 2)
{
    Console.WriteLine($"Você está classificado como suspeito.");
    
}
else if (culpa == 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"VOCÊ É O ASSASSINO");
    Console.ResetColor();
    
}
else
{
    Console.WriteLine($"Você é um cúmplice");
}
Console.WriteLine($"Tecle <Enter> para fechar o console");
string fechar = Console.ReadLine();
Console.Clear();
Console.Beep();