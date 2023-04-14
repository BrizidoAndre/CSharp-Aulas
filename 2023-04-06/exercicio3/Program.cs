Console.WriteLine($"Por favor digite o numero que voce deseja ver a tabuada");
float tabuada = float.Parse(Console.ReadLine());
Console.WriteLine($"Ate que ponto o usuario deseja que a tabuada pare?");
int multiplica = int.Parse(Console.ReadLine()); 

for (int i = 0; i <= multiplica; i++)
{
    Console.WriteLine($"{tabuada} * {i} = " + tabuada*i );
    
}