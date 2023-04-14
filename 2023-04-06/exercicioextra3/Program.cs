float tabuada = 0;
while (tabuada <= 10)
{
    Console.WriteLine($"Tabuada do {tabuada}");
    for (int i = 0; i <= 10; i++)
    {

        Console.WriteLine($"{tabuada} * {i} = " + (tabuada * i));
    }
    tabuada++;
}