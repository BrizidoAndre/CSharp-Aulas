Console.WriteLine($"Por favor, informe qual é seu salário");
int salario = int.Parse(Console.ReadLine());

Console.WriteLine($"Agora, informe qual foi seus gastos");
int gastos = int.Parse(Console.ReadLine());

string balanco = (gastos > salario) ? "Orçamento estourado" : "Gastos dentro do orçamento";
Console.WriteLine($"{balanco}");
