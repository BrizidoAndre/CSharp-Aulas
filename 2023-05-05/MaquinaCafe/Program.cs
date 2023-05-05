using MaquinaCafe;
Maquina cafe = new Maquina();

Console.WriteLine(@$"

Super CafeteiraTabajaras Plus++");

do
{
    Console.WriteLine(@$"
-------------------
      MENU

1 - Fazer café padrão (10) gramas
2 - Fazer café personalizado (x) gramas
3 - Ver açúcar na máquina
4 - Repor açucar
5 - Sair

");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            cafe.FazerCafe();
            break;
        case "2":
            Console.WriteLine($"Por favor digite a quantidade de gramas de açucar que deseja (apenas números)");
            int acucar = int.Parse(Console.ReadLine());

            cafe.FazerCafe(acucar);
            break;
        case "3":
            Console.WriteLine($"Gramas de açucar disponível {cafe.AcucarDisponivel}");
            break;
        case "4":
            cafe.ReporAcucar();
            break;
        case "5":
            Console.WriteLine($"Saindo do programa.");
            Console.Write($"Encerrando");
            for (var i = 0; i < 4; i++)
            {
                Console.Write($".");
                Thread.Sleep(600);
            }
            Console.WriteLine($".");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine($"Caractere Inválido");
            break;
    }

} while (true);