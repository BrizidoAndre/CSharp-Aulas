using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto2;

namespace Projeto2
{
    public class Produto
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

        public string NomeProduto { get; private set; }
        public int Codigo { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Marca Marca { get; private set; }
        Marca ObjetoMarca = new Marca();
        public Usuario CadastradoPor { get; private set; }
        public List<Produto> ListaDeProdutos { get; private set; }
        public Produto()
        {
        }
        public Produto(string _nomeProduto, int _codigoProduto, float _precoProduto, Marca _marca, Usuario _usuario)
        {
            NomeProduto = _nomeProduto;
            Codigo = _codigoProduto;
            Preco = _precoProduto;
            DataCadastro = DateTime.Now;
            Marca = _marca;
            CadastradoPor = _usuario;
        }
        public string Cadastrar(Produto _produto)
        {
            Console.WriteLine($"Vamos cadastrar o produto!");
            Console.WriteLine($"Qual o nome do produto?");
            string nomeProduto = Console.ReadLine();
            CorVerde("Nome Registrado!");
            Console.WriteLine($"Qual o código do produto (apenas números)");
            int codigoProduto = int.Parse(Console.ReadLine());
            Console.WriteLine($"Qual o preço do produto?");
            float precoProduto = float.Parse(Console.ReadLine());
            Console.WriteLine($"Qual o código da marca?");
            int codigoMarca = int.Parse(Console.ReadLine());



            return "";
        }
        public List<Produto> Listar()
        {
            return ListaDeProdutos;
        }
        public string Deletar(Produto _produto)
        {
            return "";
        }
    }
}