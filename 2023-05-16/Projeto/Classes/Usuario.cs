namespace Projeto.Classes
{
    public class Usuario
    {
        static void CorAmarela(string texto)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(texto);
            Console.ResetColor();
            
        }
        static void CorVerde(string texto)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(texto);
            Console.ResetColor();
            
        }
        public Login login { get; private set; }
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Cadastrar(Usuario _usuario)
        {
            Console.WriteLine($"Vamos cadastrar o usuário!");
            Console.WriteLine($"Primeiro Vamos começar com o nome de usuário");
            Nome = Console.ReadLine();
            CorVerde("Nome registrado!");
            Console.WriteLine($"Agora vamos cadastrar a senha (min de 6 caracteres, max de 10 caracteres)");
            Senha = Console.ReadLine();
            while (Senha.Length < 6 || Senha.Length > 10)
            {
                Console.WriteLine($"A senha não segue os parâmetros indicados, por favor insira novamente");
                Senha = Console.ReadLine();
            }
            CorVerde("Senha registrada!");
            return "O cadastro foi realizado";
        }
        public string Deletar(Usuario _usuario)
        {

        }
    }
}