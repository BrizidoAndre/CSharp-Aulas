string[] produto = new string[10];
float[] preco = new float[10];
bool[] promocao = new bool[10];
float[] desconto = new float[10];
string opcao = "";

static string CadastroProduto(int i)
{
    Console.WriteLine($"Por favor digite o nome do {i} produto");
    return Console.ReadLine().ToUpper();
}

static float CadastroPreco(int i)
{
    Console.WriteLine($"Agora digite o valor do {i} produto");
    return (float)Math.Round(float.Parse(Console.ReadLine()), 2);
}

static bool CadastroPromocao(int i)
{
    string promocao = "teste";
    do
    {
        Console.WriteLine(@$"Agora digite se o {i} produto esta em promocao
    S - para sim
    N - para nao");
        promocao = Console.ReadLine().ToLower();

        switch (promocao)
        {
            case "s":
                return true;

            case "n":
                return false;
            default:
                Console.WriteLine($"Caractere invalido, tente novamente");
                break;
        }
    } while (true);

}


while (true)
{
    Console.WriteLine(@$"
 ----------------------------------------
|Bem vindo ao caixa automatico, por      |
|favor selecione uma de nossas opcoes    |
 ----------------------------------------
1 - Para adicionar os produtos
2 - Para listar os produtos adicionados
0 - Para sair
");
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            for (var i = 0; i < 2; i++)
            {
                produto[i] = CadastroProduto(i + 1);
                preco[i] = CadastroPreco(i + 1);
                promocao[i] = CadastroPromocao(i + 1);
                if (promocao[i])
                {
                    Console.WriteLine($"Por favor digite o valor de desconto");
                    desconto[i] = float.Parse(Console.ReadLine());
                }
            }
            break;


        case "2":
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine(@$"Nome:                 {produto[i]}");
                if (promocao[i])
                {
                    Console.WriteLine(@$"Esta em promocao?     Sim
Preco:                {preco[i]}");

                }
                else
                {
                    Console.WriteLine(@$"Esta em promocao?     Nao
Preco:                {preco[i]}");

                }
                if (promocao[i])
                {
                    Console.WriteLine(@$"Desconto:            -{desconto[i]}
Preco final:          {preco[i] - desconto[i]}");
                }
            }
            break;

        case "0":
            Console.Write($"Fechando o Console");
            for (var i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write($".");
            }
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine($"Nao corresponde a uma de nossas opcoes, por favor tente novamente");
            break;
    }
}