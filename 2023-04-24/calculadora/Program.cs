using calculadora;
Funcao calcular = new Funcao();
static string Pergunta()
{
    Console.WriteLine(@$"Por favor insira a função aritmética que o senhor deseja executar
    + Para somar
    - Para subtrair 
    * Para multiplicar
    ; Para dividir");
    return Console.ReadLine();

}
Console.WriteLine(@$"
Bem Vindo a Calculadora!");
string funcao = Pergunta();

Console.WriteLine($"Por favor, digite o primeiro número");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Agora digite o segundo número");
float n2 = float.Parse(Console.ReadLine());

switch (funcao)
{
    case "+":
    Console.WriteLine($"O resultado é ");
    Console.WriteLine(calcular.Adicao(n1,n2));
        break;
    case "-":
        break;
    case "*":
        break;
    case "/":
        break;
    default:
        break;
}
