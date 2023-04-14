Console.WriteLine($"Bem vindo. Vamos calcular o preço das maçãs. Por favor digite quantas maçãs você pegou:");
int maca = int.Parse(Console.ReadLine());
if (maca >= 12)
{
    float macabarata = 0.25F * maca;
    Console.WriteLine($"Foram {maca} portanto isso deu {Math.Round(macabarata, 2)} reais");
}
else{
    float macapreco = 0.3F * maca;
    Console.WriteLine($"Foram {maca} portanto isso deu {Math.Round(macapreco, 2)} reais");
}
