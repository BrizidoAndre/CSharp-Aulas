Console.WriteLine(@$"

Bem Vindo ao menu de bebidas. Aqui voce pode escolher
bebidas a seu gosto, no entanto neste instante temos 
apenas 6 bebidas disponiveis:

-------------------------------------
|   Aperte 1 para Coca-Cola         |
|   Aperte 2 para Chocolate Quente  |
|   Aperte 3 para Cha de Camomila   |
|   Aperte 4 para Uisque            |
|   Aperte 5 para um Gin            |
|   Aperte 6 para Guarana Jesus     |
-------------------------------------");

float bebida = float.Parse(Console.ReadLine());

switch (bebida)
{
    case 1:
        Console.WriteLine(@$"
Voce escolheu:
                            Coca-Cola
                                    _                                   
                                  .!.!.                             
                                   ! !                                   
                                   ; :                                
                                  ;   :                                
                                 ;_____:                                 
                                 ! Coca!                                 
                                 !_____!                                 
                                 :     :
                                 :     ;                                       
                                 .'   '.                             
                                 :     :                            
                                  '''''");
        break;
    case 2:
        Console.WriteLine(@$"
Voce escolheu:
                            Chocolate Quente");
        break;
    case 3:
        Console.WriteLine(@$"
Voce escolheu:
                            Cha de Camomila");
        break;
    case 4:
        Console.WriteLine(@$"
Voce escolheu:
                            Uisque");
        break;
    case 5:
        Console.WriteLine(@$"
Voce escolheu:
                            Gin");
        break;
    case 6:
        Console.WriteLine(@$"
Voce escolheu:
                            Guarana Jesus");
        break;
    default:
        Console.WriteLine($"Essa selecao nao corresponde a uma de nossas opcoes.");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        break;
}
if (bebida == 1 || bebida == 4 || bebida == 5)
{
    Console.WriteLine($"O senhor gostaria de gelo? Digite 1 para sim ou 2 para nao");
    byte gelo = byte.Parse(Console.ReadLine());
    switch (gelo)
    {
        case 1:
            Console.WriteLine($"Bebida com Gelo selecionada!");
            break;
        case 2:
            Console.WriteLine($"Bebida sem Gelo Selecionada");
            break;
        default:
            Console.WriteLine($"Essa opcao nao corresponde a uma selecao");
            break;
    }
}
Console.WriteLine($"Aproveite sua Bebida!!!");


