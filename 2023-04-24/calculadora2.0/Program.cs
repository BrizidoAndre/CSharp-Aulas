using calculadora2.OperacoesMatematicas;
Funcao conta = new Funcao();
bool repetir = false;
static string Pergunta()
{
    Console.WriteLine(@$"
    Por favor insira a função aritmética que o senhor deseja executar:
    + Para somar
    - Para subtrair 
    * Para multiplicar
    ; Para dividir");
    return Console.ReadLine();

}

Console.WriteLine(@$"
Bem Vindo a Calculadora!");

do
{
string operacao = Pergunta();

Console.WriteLine($"Por favor, digite o primeiro número");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Agora digite o segundo número");
float n2 = float.Parse(Console.ReadLine());

switch (operacao)
{
    case "+":
    Console.Write($"O resultado da operação é ");
    Console.WriteLine(conta.Adicao(n1,n2));
        break;
    case "-":
    Console.Write($"O resultado da operação é ");
    Console.WriteLine(conta.Subtracao(n1, n2));
        break;
    case "*":
    Console.Write($"O resultado da operação é ");
    Console.WriteLine(conta.Multiplicacao(n1, n2));
        break;
    case "/":
    Console.Write($"O resultado da operação é ");
    Console.WriteLine(conta.Divisao(n1, n2));
        break;
    default:
    Console.Write($"Erro de operação, reiniciando sistema");
    for (var i = 0; i < 3; i++)
    {
        Thread.Sleep(1000);
        Console.Write($".");
    }
    Console.WriteLine($".");
    repetir = true;
        break;
}
} while (repetir);
