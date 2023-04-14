Console.WriteLine($"Bem vindo! Digite a presença sem o sinal de porcentagem do indivíduo:");
int presença = int.Parse(Console.ReadLine());
if ( presença >= 75 )
{
    Console.WriteLine($"Digite a média final do aluno");
    float media = float.Parse(Console.ReadLine());
    if (media > 7)
    {
        Console.WriteLine($"Seu aluno está aprovado");
    }
    else if (media > 3)
    {
        Console.WriteLine($"Seu aluno está em recuperação");
    }
    else
    {
        Console.WriteLine($"Seu aluno já está reprovado");
    }
}
else
{
    Console.WriteLine($"Seu aluno já está reprovado");
}
