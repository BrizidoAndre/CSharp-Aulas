using MVC_Evento.Controller;

EventoController EC = new EventoController();

string opcao;
do
{
    Console.WriteLine(@$"
MENU

1 - Cadastrar Evento
2 - Listar Evento

0 - Desligar");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
        EC.CadastarEvento();
            break;
        case "2":
        EC.Listar();
            break;
        case "0":
        Console.WriteLine($"Desligando");
        Environment.Exit(0);
            break;
        default:
            Console.WriteLine($"Comando inválido");

            break;
    }

} while (true);