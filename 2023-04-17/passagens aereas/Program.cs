const string senha = "123456";
string[] nome = new string[1000];
string[] origem = new string[1000];
string[] destino = new string[1000];
string[] data = new string[1000];
int a = 0;


// static string Cadastrar(){

// }

Console.WriteLine($"Bem vindo ao site da Ar Airlines! Por favor para entrar em seu perfil digite a senha");
string senhaTentativa = Console.ReadLine();


while (senha != senhaTentativa)
{
    for (var i = 3; i > 0; i--)
    {
        Console.WriteLine($"Senha incorreta. Digite novamente, {i} chances restando");
        senhaTentativa = Console.ReadLine();
        if (senhaTentativa == senha)
        {
            i = 0;
        }
    }
    if (!(senhaTentativa == senha))
    {
        Console.WriteLine($"Nenhuma chance restando. Acesso negado");
        Environment.Exit(0);
    }
}


Console.WriteLine(@$"Sua senha funcionou!");
while (true)
{
    Console.WriteLine(@$"Bem vindo ao seu portal
1 - Cadastrar passagem
2 - Listar passagens
3 - Sair");
    byte menu = byte.Parse(Console.ReadLine());

    switch (menu)
    {
        case 1:
            Console.WriteLine($"Quantas pessoas viajarao?");
            int pessoas = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o ponto de origem?");
            origem[a] = new string(Console.ReadLine());

            Console.WriteLine($"Qual o seu destino?");
            destino[a] = new string(Console.ReadLine());

            Console.WriteLine($"Quando voce ira partir");
            data[a] = new string(Console.ReadLine());

            for (int i = 0; i < pessoas; i++)
            {
                Console.WriteLine($"Qual o nome do {i + 1} passageiro?");
                nome[i] = Console.ReadLine();
                nome[a] = nome[i];
                origem[i] = origem[a];
                destino[i] = destino[a];
                data[i] = data[a];
                a++;
                origem[a] = origem[i];
                destino[a] = destino[i];
                data[a] = data[i];
                a--;
            }
            break;
        case 2:
            foreach (var item in nome)
            {
                Console.WriteLine(@$"
Nome:{nome[a]}
Origem:{origem[a]}
Destino:{destino[a]}
Data:{data[a]}
");   
            }
            break;
        case 3:
        Console.WriteLine($"Saindo do programa");
        Environment.Exit(0);
        break;
        default:
            Console.WriteLine($"O numero digitado nao corresponde a uma de nossas funcoes");
            break;
    }
}
