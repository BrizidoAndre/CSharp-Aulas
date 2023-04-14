Console.WriteLine($"Aqui esta o cadastro, por favor digite o login");
string login = Console.ReadLine();

Console.WriteLine($"Agora digite sua senha");
string senha = Console.ReadLine();

while(senha == login)
{
    Console.WriteLine($"Sua senha nao pode ser a mesma do login, por favor digite uma nova senha.");
    senha = Console.ReadLine();
}
Console.WriteLine($"Seu login e {login} e sua nova senha e {senha}");
