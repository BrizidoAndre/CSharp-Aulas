const string senha = "123456";
string resposta = "s";
string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];
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
        do
        {
        for (var i = 0; i < 5; i++)  
        {
            Console.WriteLine($"Qual o nome do passageiro");
            nome[i] = new string(Console.ReadLine());

            Console.WriteLine($"Qual o ponto de origem?");
            origem[i] = new string(Console.ReadLine());

            Console.WriteLine($"Qual o seu destino?");
            destino[i] = new string(Console.ReadLine());

            Console.WriteLine($"Quando voce ira partir");
            data[i] = new string(Console.ReadLine());
        Console.WriteLine($"Voce quer cadastrar uma nova passagem ");
        resposta = Console.ReadLine().ToLower();
        } 
        }while (resposta == "s");     
        
        break;
        case 2:
            for (var i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(@$"
Nome: {nome[i]}
Origem: {origem[i]}
Destino: {destino[i]}
Data: {data[i]}");
                
            }
        break;
        case 3:
        Console.WriteLine($"Fechando programa...");
        Environment.Exit(0);
        break;
        default:
        Console.WriteLine($"A selecao nao corresponde a uma de nossas opcoes.");
        break;
    }
}