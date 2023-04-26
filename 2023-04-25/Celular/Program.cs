using Celular;

Telephone cel = new Telephone();

string opcao;

Console.WriteLine(@$"Obrigado pela compra!");
Thread.Sleep(1000);
Console.WriteLine($"Celular foi ligado automaticamente!");

while (true)
{   
while(cel.ligado)
{
    Console.WriteLine(@$"Digite o comando que deseja executar
1 - Enviar Mensagem
2 - Fazer Ligacao
3 - Mostrar informacoes do dispositivo

0 - Desligar dispositivo");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
        cel.EnviarMensagem();
            break;
        case "2":
        cel.FazerLigacao();
            break;
        case "3":
        cel.MostrarInformacoes();
            break;
        case "0":
        cel.Desligar();
            break;
        default:
        Console.WriteLine($"Caractere nao corresponde");
            break;
    }
}    
Console.WriteLine(@$"

Celular desligado. Deseja liga-lo?

S para sim
N para nao");
string ligar = Console.ReadLine().ToLower();
cel.ligado = ligar == "s"? true : false;

}
