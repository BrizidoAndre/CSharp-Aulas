﻿using CadastroAlunos;

Aluno aluno = new Aluno();

Console.WriteLine($"Bem vindo! Vamos cadastrar o aluno e verá se o mesmo possui bolsa");

Console.WriteLine($"Qual o nome do aluno?");
aluno.nome = Console.ReadLine();

Console.WriteLine($"Qual o curso do aluno?");
aluno.curso = Console.ReadLine();

Console.WriteLine($"Qual a idade do aluno?");
aluno.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o seu RG");
aluno.RG = Console.ReadLine();

// Declarando a variavel so para nao dar problema de repeticao
string resposta = "";
do
{
    Console.WriteLine(@$"O aluno é bolsista?
S - Para sim
N - Para não");
    resposta = Console.ReadLine().ToLower();

    switch (resposta)
    {
        case "s":
            aluno.bolsista = true;
            break;
        case "n":
            aluno.bolsista = false;
            break;
        default:
            Console.WriteLine($"Operacao invalida");
            break;
    }
} while (resposta != "s" && resposta != "n");

Console.WriteLine($"Digite a Media Final do aluno");
aluno.mediaFinal = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o valor da mensalidade");
aluno.Mensalidade = float.Parse(Console.ReadLine());

Console.WriteLine($"Cadastro Realizado!");
int opcao = 0;
Console.WriteLine(@$"Portal do aluno
1 - Ver Media final
2 - Ver Mensalidade");
opcao = int.Parse(Console.ReadLine());
switch (opcao)
{
    case 1:
    aluno.VerMediaFinal();
        break;
    case 2:
    aluno.VerMensalidade();
        break;
    default:
    Console.WriteLine($"Caractere Invalido");
        break;
}
