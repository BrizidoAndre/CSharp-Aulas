using _2023_04_20;


Personagem tony = new Personagem();

Console.WriteLine($"Digite o nome do personagem");
tony.nome = Console.ReadLine();

Console.WriteLine($"Digite a idade do personagem");
tony.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a armadura do personagem");
tony.armadura = Console.ReadLine();

Console.WriteLine($"Digite a IA do personagem");
tony.ia = Console.ReadLine();

Console.WriteLine(@$"
{tony.nome};
{tony.idade};
{tony.armadura};
{tony.ia}.
");

tony.Atacar();
Console.WriteLine(tony.Defender());
tony.RestaurarArmadura();
Console.WriteLine(tony.Aparar());
