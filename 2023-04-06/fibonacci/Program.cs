int a = 1;
int b = 1;
do
{
    Console.WriteLine($"{a} ainda é abaixo de 500");
    Console.WriteLine($"{b} ainda é abaixo de 500");
    a = a + b;
    b = b + a;
} while (b < 500 || a < 500);
if (a > b)
{
    Console.WriteLine($"{b} é o primeiro valor que ultrapassa 500");
}
else
{
    Console.WriteLine($"{a} é o primeiro valor que ultrapassa 500");
}
