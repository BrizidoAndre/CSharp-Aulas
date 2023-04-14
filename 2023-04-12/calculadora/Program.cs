static float Plus(float n1, float n2)
{
    return (n1 + n2);
}
static float Multiply(float n1, float n2)
{
    return (n1 * n2);
}
static float Divide(float n1, float n2)
{
    return (n1 / n2);
}
static float Less(float n1, float n2)
{
    return (n1 - n2);
}

Console.WriteLine($"Bem vindo a Calculadora! Uma inovação do mundo mundial. Por favor digite o primeiro número");
float num1 = float.Parse(Console.ReadLine());

Console.WriteLine(@$"
Agora digite qual operador você quer utilizar desta vez
+ para adicionar
- para subtrair
* para multiplicar
/ para dividir");
char operador = char.Parse(Console.ReadLine().ToLower());

Console.WriteLine($"Por fim digite seu segundo número");
float num2 = float.Parse(Console.ReadLine());

switch (operador)
{
    case '*':
        Console.WriteLine($"A resposta é:");
        Console.WriteLine(Multiply(num1, num2));
        break;
    case '+':
        Console.WriteLine($"A resposta é:");
        Console.WriteLine(Plus(num1, num2));
        break;
    case '-':
        Console.WriteLine($"A resposta é:");
        Console.WriteLine(Less(num1, num2));
        break;
    case '/':
        Console.WriteLine($"A resposta é:");
        Console.WriteLine(Divide(num1, num2));
        break;
}
