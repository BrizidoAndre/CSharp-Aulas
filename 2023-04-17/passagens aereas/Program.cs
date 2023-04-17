const string senha = "123456";
string[] nome;
string[] origem;
string[] destino;
string[] data;


static string Cadastrar(){

}

Console.WriteLine($"Bem vindo ao site da Ar Airlines! Por favor para entrar em seu perfil digite a senha");
string senhaTentativa = Console.ReadLine();


while (senha!=senhaTentativa)
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

Console.WriteLine(@$"Bem vindo ao seu portal
1 - Cadastrar passagem
2 - Listar passagens
0 - Sair");
byte menu = byte.Parse(Console.ReadLine());

switch (menu)
{
    case 1:

        break;
    default:
        break;
}
