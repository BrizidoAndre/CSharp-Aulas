string[] produto = new string[10];
float[] preco = new float[10];
bool[] promocao = new bool[10];

static string CadastroProduto(int i)
{
    Console.WriteLine($"Por favor digite o nome do {i} produto");
    return Console.ReadLine();
}
static float CadastroPreco(int i)
{
    Console.WriteLine($"Agora digite o valor do {i} produto");
    return (float)Math.Round(float.Parse(Console.ReadLine()), 2);
}
static bool CadastroPromocao(int i)
{
    Console.WriteLine(@$"Agora digite se o {i} produto esta em promocao
    S para sim
    N para nao");
    char promocao = char.Parse(Console.ReadLine());
    switch (promocao)
    {
        case 's':
            return true;
        case 'n':
            return false;
        default:
            Console.WriteLine($"Caractere invalido");
            return false;
    }

}
