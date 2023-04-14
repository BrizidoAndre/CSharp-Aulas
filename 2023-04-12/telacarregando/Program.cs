static void BarraCarregamento(string texto, int quantidadeDePontinhos, int tempo)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(texto);
    
    for (var i = 0; i < quantidadeDePontinhos; i++)
    {
        Console.Write($".");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}
BarraCarregamento("Testando", 15, 700);

BarraCarregamento("Finalizando", 20, 400);

BarraCarregamento("Aguarde", 3, 2000);

BarraCarregamento("Cadastrando", 90, 100);

BarraCarregamento("Logando", 25, 200);
