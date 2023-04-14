// Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.
Console.WriteLine($"Bem vindo! Por favor digite o raio do círculo:");
float raio = float.Parse(Console.ReadLine());
float diametro = (raio + raio);
float area = ((float) Math.Round((float) Math.PI * (raio * raio),2));
float perimetro = ((float) Math.Round(diametro * (float) (Math.PI), 2));

Console.WriteLine($"Bom, se seu círculo possui esse raio, seu diâmetro é de {diametro}, seu perímetro é de {perimetro} sua área é de {area}");
Console.WriteLine($"Tecle <Enter> para fechar o console");
string fechar = Console.ReadLine();
Console.Clear();