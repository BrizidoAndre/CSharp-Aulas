//Um programa que receba o nome do usuario e a senha a senha deve ter 6 caracteres
//Validar a senha
//enquanto a sneha nao estiver com a regra pedida, preciso que
//o programa nao se encerre e que solicite que seja digitado uma senha no padrao requerido
//caso a senha informada esteja correta com 6 caracteres, exiba uma mensagem de ok

Console.WriteLine($"Digite seu nome");
string nome = Console.ReadLine();

Console.WriteLine($"Digite a sua senha (precisa ter 6 caracteres)");
string senha = Console.ReadLine();

while (senha.Length != 6)
{
    Console.WriteLine($"Sua senha precisa de 6 caracteres, por favor tente novamente");
    senha = Console.ReadLine();
}

Console.WriteLine($"Usuario e senha registrados com sucesso!");