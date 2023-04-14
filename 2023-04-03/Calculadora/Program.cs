float resultado = 0;
Console.WriteLine(@$"
______________________________________________
|Calculadora pessoal, para pessoa pessoal.    |
|Por favor digite o caractere que sera usado  |
|para o calculo no aplicativo                 |
|+ Para adicao                                |
|- Para subtrair                              |
|* Para multiplicar                           |
|/ Para dividir                               |
______________________________________________
");
char operacao = char.Parse(Console.ReadLine());

Console.WriteLine($"Agora digite o primeiro numero");
float num1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero");
float num2 = float.Parse(Console.ReadLine());

switch (operacao)
{
    case '+':
        resultado = num1 + num2;
        Console.WriteLine($"O resultado da operacao e {resultado}");
        break;
    case '-':
        resultado = num1 - num2;
        Console.WriteLine($"O resultado da operacao e {resultado}");
        break;
    case '*':
        resultado = num1 * num2;
        Console.WriteLine($"O resultado da operacao e {resultado}");
        break;
    case '/':
        resultado = num1 / num2;
        Console.WriteLine($"O resultado da operacao e {resultado}");
        break;
     
    default:
        Console.WriteLine($"A operacao informada nao e suportada pela nossa calculadora");
        break;
}
Console.WriteLine($"Teste");
