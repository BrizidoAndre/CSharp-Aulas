using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2
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
        public List<Usuario> listaUsuario = new List<Usuario>();
        public Login login { get; private set; }
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Usuario()
        {
        }
        public Usuario(string _nomeUsuario, string _senhaUsuario, string _emailUsuario)
        {
            Nome = _nomeUsuario;
            Senha = _senhaUsuario;
            Email = _emailUsuario;
            DataCadastro = DateTime.Now;
        }
        public void Cadastrar()
        {
            Console.WriteLine($"Vamos cadastrar o usuário!");
            Console.WriteLine($"Primeiro Vamos começar com o nome de usuário");
            string nome = Console.ReadLine();
            CorVerde("Nome registrado!");
            Console.WriteLine($"Por favor, digite o e-mail que será cadastrado com a conta");
            string email = Console.ReadLine();
            while (email.Length < 11 || email.Length > 256)
            {
                Console.WriteLine($"O email não segue os parâmetros indicados, por favor digite novamente");
                email = Console.ReadLine();
            }
            Console.WriteLine($"Agora vamos cadastrar a senha (min de 6 caracteres, max de 10 caracteres)");
            string senha = Console.ReadLine();
            while (senha.Length < 6 || senha.Length > 10)
            {
                Console.WriteLine($"A senha não segue os parâmetros indicados, por favor digite novamente");
                senha = Console.ReadLine();
            }
            CorVerde("Senha registrada!");
            listaUsuario.Add(
                new Usuario(nome, senha, email)
            );
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
        public bool Logar()
        {
            Usuario usuariologar = new Usuario();
            Console.WriteLine($"Digite o Nome do usuário");
            string nome = Console.ReadLine();
            usuariologar = listaUsuario.Find(z => z.Nome == nome);
            Console.WriteLine($"Agora digite a senha");
            string senha = Console.ReadLine();
            if (usuariologar != null && usuariologar.Senha == senha)
            {
                Console.WriteLine($"Entrando no portal");
                return true;
            }
            else
            {
                Console.WriteLine($"Usuario ou senha não encontrados");
                return false;
            }

        }
        public Usuario IdentificadorUsuario(string _nome)
        {
            Usuario usuario = listaUsuario.Find(z => z.Nome == _nome);
            return usuario;
        }
        public void Deletar()
        {
            Console.WriteLine($"Por favor insira o Email do Usuário");
            string emailUsuario = Console.ReadLine();
            Usuario _usuario = listaUsuario.Find(z => z.Email == emailUsuario);
            int index = listaUsuario.IndexOf(_usuario);
            listaUsuario.RemoveAt(index);
            CorVerde("Usuário removido!");
        }
    }
}
