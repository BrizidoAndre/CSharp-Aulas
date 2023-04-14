int mulheres = 0;
int homens = 0;
int sim = 0;
int nao = 0;
int homensnao = 0;
int mulhersim = 0;

for (var i = 0; i <= 10; i++)
{
    Console.WriteLine($"{i} - Qual seu sexo, digite 'm' para Masculino e 'f' para feminino");
    char sexo = char.Parse(Console.ReadLine().ToLower());

    switch (sexo)
    {
        case 'f':
            mulheres++;
            break;

        case 'm':
            homens++;
            break;

        default:
            do
            {
                Console.WriteLine($"Essa nao e uma letra valida, por favor digite novamente");
                sexo = char.Parse(Console.ReadLine().ToLower());

                switch (sexo)
                {
                    case 'f':
                        mulheres++;
                        break;

                    case 'm':
                        homens++;
                        break;
                }
            } while (sexo != 'm' && sexo != 'f');
            break;
    }

    Console.WriteLine($"Voce disse Sim ou Nao? Digite 's' para sim e 'n' para nao");
    char resposta = char.Parse(Console.ReadLine().ToLower());
    switch (resposta)
    {
        case 's':
            sim++;
            break;

        case 'n':
            nao++;
            break;

        default:
            do
            {
                Console.WriteLine($"Esse nao e uma letra valida, por favor digite novamente");
                resposta = char.Parse(Console.ReadLine().ToLower());
                switch (resposta)
                {
                    case 's':
                        sim++;
                        break;

                    case 'n':
                        nao++;
                        break;
                }
            } while (resposta != 's' && resposta != 'n');
            break;
    }
    if (sexo == 'f' && resposta == 's')
    {
        mulhersim++;
    }
    if (sexo == 'm' && resposta == 'n')
    {
        homensnao++;
    }
}

int total = mulheres + homens;
float porcentagem = (float) Math.Round( (float) homensnao / total, 2) * 100;
Console.WriteLine($"A pesquisa foi finalizada!");

Console.WriteLine(@$"
- {sim} pessoas respoderam sim 
- {nao} pessoas responderam nao.
- {mulhersim} mulheres disseram sim
- {porcentagem}% da pesquisa foram homens que responderam nao
em um total de {homens} homens analisados");

