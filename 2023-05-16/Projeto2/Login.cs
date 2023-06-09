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
        public void Logon(bool _logado)
        {
            Logado = _logado;
        }
        public bool Logar()
        {
            Console.WriteLine($"Você está logando no sistema. Por favor digite o usuário.");
            logarUsuario = Console.ReadLine();
            Console.WriteLine($"Agora digite a senha do usuário.");
            logarSenha = Console.ReadLine();
            if (logarUsuario == usuario.Nome && logarSenha == usuario.Senha)
            {
                Logon(true);
                Console.WriteLine($"Login Efetuado");
                return true;
            }
            else
            {
                Logon(false);
                Console.WriteLine($"Nome ou senha incorretos.");
                return false;
            }
        }
        public bool Deslogar()
        {
            return false;
        }
        public void Menu()
        {
            bool repeticao = true;
            do
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

            [0] - Deslogar");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar();
                        break;
                    case "2":
                        produto.Listar();
                        break;
                    case "3":
                        produto.Deletar();
                        break;
                    case "4":
                        marca.Cadastrar();
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":
                        marca.Deletar();
                        break;
                    case "0":
                        repeticao = Deslogar();
                        break;
                    default:
                        Console.WriteLine($"Caractere incorreto!");
                        break;
                }
            } while (repeticao);
        }
        public void MenuInicial()
        {
            Console.WriteLine($"Bem vindo ao portal dos Supermercados Itaquaquecetuba");
            Console.WriteLine(@$"
Portal

1 - Cadastrar
2 - Logar
3 - Listar usuarios
4 - Deletar usuarios

0 - Sair");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    usuario.Cadastrar();
                    break;
                case "2":
                    if (usuario.Logar())
                    {
                        Menu();
                    }
                    break;
                case "3":
                    usuario.Listar();
                    break;
                case "4":
                    usuario.Deletar();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                Console.WriteLine($"Caractere inválido");
                    break;
            }


        }
    }
}