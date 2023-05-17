using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Login
    {
        Usuario usuario = new Usuario();
        Produto produto = new Produto();
        Marca marca = new Marca();
        List<Marca> listaMarca = new List<Marca>();
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
        public string logarUsuario { get; private set; }
        public string logarSenha { get; private set; }
        public bool Logado { get; private set; }
        public Login(bool _logado)
        {
            Logado = _logado;
        }
        public string Logar()
        {
            Console.WriteLine($"Você está logando no sistema. Por favor digite o usuário.");
            logarUsuario = Console.ReadLine();
            Console.WriteLine($"Agora digite a senha do usuário.");
            logarSenha = Console.ReadLine();
            if (logarUsuario == usuario.Nome && logarSenha == usuario.Senha)
            {
                Logado = true;
                Console.WriteLine($"Login Efetuado");
            }
            else
            {
                Logado = false;
                Console.WriteLine($"Nome ou senha incorretos.");
            }


            return "";
        }
        public string Deslogar(Usuario _usuario)
        {
            return "";
        }
        public void Menu()
        {
            Console.WriteLine(@$"
            Menu de cadastros
            
            [1] - Cadastrar Produto
            [2] - Listar Produtos
            [3] - Deletar Produtos

            ++++++++++++++++++++++

            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Deletar Marcas

            [0] - Sair");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                marca.Cadastrar();
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "0":
                    break;
                default:
                    break;
            }


        }
    }
}