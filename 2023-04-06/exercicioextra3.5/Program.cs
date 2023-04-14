Console.WriteLine($"Qual tabuada você deseja saber.");
float tabuada= float.Parse(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{tabuada} x {i}  = {tabuada * i}");
    
}