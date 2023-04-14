Console.WriteLine($"Por favor digite seu nome");
string nome = Console.ReadLine();

while (nome.Length == 0)
{
    Console.WriteLine($"Voce deve ter um nome, por favor digite novamente");
    nome = Console.ReadLine();
}

Console.WriteLine($"Qual sua idade");
int idade = int.Parse(Console.ReadLine());

while (idade < 0 || idade > 140)
{
    Console.WriteLine($"Essa nao e uma idade valida, por favor digite novamente");
    idade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Digite seu salario");
float salario = (float)Math.Round(float.Parse(Console.ReadLine()),2);

while (salario < 0)
{
    Console.WriteLine($"Voce deve ter um salario, por favor digite novamente");
    salario = float.Parse(Console.ReadLine());
}

Console.WriteLine(@$"
Agora determine seu estado civil dentro da sequencia abaixo:
s - Solteiro
c - Casado
v - Viuvo
d - Divorciado");
char civil = char.Parse(Console.ReadLine());

while (civil != 's' && civil != 'c' && civil != 'v' && civil != 'd')
{
    Console.WriteLine($"Esse estado civil nao corresponde, por favor digite novamente");
    civil = char.Parse(Console.ReadLine());
}
string estadoCivil = "";

switch (civil)
{
    case 's':
        estadoCivil = "Solteiro";
        break;
    case 'c':
        estadoCivil = "Casado";
        break;
    case 'v':
        estadoCivil = "Viuvo";
        break;
    case 'd':
        estadoCivil = "Divorciado";
        break;
}

Console.WriteLine($"Tudo foi registrado!");

Console.WriteLine($"Seu nome e {nome} com {idade} anos com salario de {salario} reais e atualmente esta {estadoCivil}.");