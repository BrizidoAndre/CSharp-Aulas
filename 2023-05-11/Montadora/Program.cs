//EXERCÍCIO PARA FIXAÇÃO - NÃO PRECISA ENTREGAR

//1 - CRIAR UMA CLASSE "CARRO"
//      - PROPRIEDADES : STRING MARCA, STRING COR

//2 - CRIAR CONSTRUTOR VAZIO E COMPLETO

//3 - CADASTRAR E INSERIR EM UMA LISTA 2 OBJETOS(DINÂMICO)
//      - ENTRADA DE DADOS PELO CONSOLE 

//4 - EXIBIR OS DADOS DOS OBJETOS NO CONSOLE (FOREACH)
using Montadora;

List<Carro> carros = new List<Carro>();
Carro carro = new Carro();
Console.Clear();

for (var i = 0; i < 2; i++)
{
    Console.WriteLine($"Por favor insira o modelo do {i+1}º carro");
    carro.Modelo = Console.ReadLine();
    
    Console.WriteLine($"Agora insira a cor do {i+1}º carro");
    carro.Cor = Console.ReadLine();

    carros.Add(carro);
    Console.Clear();
}
foreach (var item in carros)
{
    Console.WriteLine($"*********************************");
    Console.WriteLine($"Modelo do carro:  {item.Modelo}");
    Console.WriteLine($"Cor do carro:     {item.Cor}");
    Console.WriteLine($"*********************************");
    
}

