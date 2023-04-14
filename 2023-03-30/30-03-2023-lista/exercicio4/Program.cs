const int senhareal = 1234;
Console.WriteLine($"Bem vindo. Para acessar seu perfil, resta digitar sua senha");
int senhadigitada = int.Parse(Console.ReadLine());
string acesso = (senhareal == senhadigitada) ? "Bem vindo ao seu perfil" : "Senha incorreta";
Console.WriteLine($"{acesso}");