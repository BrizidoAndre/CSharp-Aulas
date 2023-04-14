int mulher = 0;
int homem = 0;
int somaIdadesHomens = 0;
int somaIdadesMulheres = 0;
bool pesquisafinal = true;
do
{
    Console.WriteLine($"Por favor coloque seu sexo. Digite 'm' para mulher e 'h' para homem");
    char sexo = char.Parse(Console.ReadLine().ToLower());
    switch (sexo)
    {
        case 'm':
            mulher ++;
            Console.WriteLine($"Reposta m validada!");

            break;
        case 'h':
            homem ++;
            Console.WriteLine($"Resposta h validada");

            break;
        default:
            do
            {
                Console.WriteLine($"Esta nao e uma resposta valida, por favor digite novamente.");
                sexo = char.Parse(Console.ReadLine().ToLower());
                switch (sexo)
                {
                    case 'm':
                        mulher++;
                        break;
                    case 'h':
                        homem++;
                        break;
                }
            } while (sexo != 'm' && sexo != 'h');
            break;
    }

    Console.WriteLine($"Agora por favor digite seu peso");
    float peso = (float)Math.Round(float.Parse(Console.ReadLine()), 2);

    Console.WriteLine($"Agora digite sua idade apenas com numeros.");
    int idade = int.Parse(Console.ReadLine());

    if (sexo == 'h')
    {
        somaIdadesHomens = somaIdadesHomens + idade;
    }
    else if (sexo == 'm')
    {
        somaIdadesMulheres = somaIdadesMulheres + idade;
    }
    Console.WriteLine($"A pesquisa foi feita? Digite s para sim");
    char final = char.Parse(Console.ReadLine().ToLower());
    if (final == 's')
    {
        pesquisafinal = false;
    }
} while (pesquisafinal);

int mediaIdadeHomens = somaIdadesHomens / homem;
int mediaIdadeMulheres = somaIdadesMulheres / mulher;

Console.WriteLine(@$"
Foram um total de: 
{homem} homens
{mulher} mulheres
{mediaIdadeHomens} e a media de idade dos homens e 
{mediaIdadeMulheres} e a media de idade das mulheres
");
