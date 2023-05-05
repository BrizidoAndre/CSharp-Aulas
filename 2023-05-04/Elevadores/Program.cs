using Elevadores;
Elevador elev = new Elevador();

string opcao;

Console.WriteLine(@$"
Bem vindo ao elevador! Antes de tudo vamos cadastrá-lo
------------------------------------------------------");
elev.Inicializa();

do
{
    Console.WriteLine(@$"
-------------------------
           Menu          

0 - Mostrar
1 - Entrar
2 - Sair
3 - Subir
4 - Descer
-------------------------");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "0":
            elev.Mostrar();
            break;
        case "1":
            elev.Entrar();
            break;
        case "2":
            elev.Sair();
            break;
        case "3":
            elev.Subir();
            break;
        case "4":
            elev.Descer();
            break;
        default:
            Console.WriteLine($"O caractere não corresponde a uma de nossas opções.");
            break;
    }
} while (true);