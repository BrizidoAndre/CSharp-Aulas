using CambioMoeda;
using System.Globalization;

Console.WriteLine($"Bem vindo ao cambio de moedas");
do
{
Console.WriteLine(@$"
--------------------
        Menu        
--------------------
1 - Real para Dolar
2 - Dolar para Real
3 - Dolar para Euro");
string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
    Console.WriteLine($"Feito o cambio, o que resta é : {ConversorMoeda.ReaisDolar().ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
        break;
    case "2":
    Console.WriteLine($"Feito o cambio, o que resta é : {ConversorMoeda.DolarReais().ToString("C", CultureInfo.CurrentCulture)}");
        break;
    case "3":
    Console.WriteLine($"Feito o cambio, o que resta é : {ConversorMoeda.DolarEuro().ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"))}");
        break;
    default:
    Console.WriteLine($"Caractere não corresponde.");
        break;
}    
} while (true);

