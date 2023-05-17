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
        List<Usuario> listaUsuario = new List<Usuario>();
        public Login login { get; private set; }
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        Usuario usuarioCadastro;
        public string Cadastrar(Usuario _usuario)
        {
            Console.WriteLine($"Vamos cadastrar o usuário!");
            Console.WriteLine($"Primeiro Vamos começar com o nome de usuário");
            usuarioCadastro.Nome = Console.ReadLine();
            CorVerde("Nome registrado!");
            Console.WriteLine($"Por favor, digite o e-mail que será cadastrado com a conta");
            usuarioCadastro.Email = Console.ReadLine();
            while (usuarioCadastro.Email.Length < 11 || usuarioCadastro.Email.Length > 256)
            {
                Console.WriteLine($"A senha não segue os parâmetros indicados, por favor digite novamente");
                usuarioCadastro.Senha = Console.ReadLine();
            }
            Console.WriteLine($"Agora vamos cadastrar a senha (min de 6 caracteres, max de 10 caracteres)");
            usuarioCadastro.Senha = Console.ReadLine();
            while (usuarioCadastro.Senha.Length < 6 || usuarioCadastro.Senha.Length > 10)
            {
                Console.WriteLine($"A senha não segue os parâmetros indicados, por favor digite novamente");
                usuarioCadastro.Senha = Console.ReadLine();
            }
            CorVerde("Senha registrada!");
            listaUsuario.Add(usuarioCadastro);
            return "O cadastro foi realizado";
        }
        public void Listar()
        {
            foreach (var item in listaUsuario)
            {
                Console.WriteLine($"Nome:  {item.Nome}");
                Console.WriteLine($"Email: {item.Email}");
                Console.WriteLine($"Senha: ***********");
                
            }
        }
        public string Deletar(Usuario _usuario)
        {
            Console.WriteLine($"Por favor insira o Email do Usuário");
            string emailUsuario = Console.ReadLine();
            _usuario = listaUsuario.Find(z => z.Email == emailUsuario);
            int index = listaUsuario.IndexOf(_usuario);
            listaUsuario.RemoveAt(index);
            CorVerde("Usuário removido!");
            return "Remoção finalizada!";
        }
    }
}