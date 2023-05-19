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
        public void Cadastrar()
        {
            Console.WriteLine($"Vamos cadastrar o produto!");
            Console.WriteLine($"Qual o nome do produto?");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine($"Qual o código do produto (apenas números)");
            int codigoProduto = int.Parse(Console.ReadLine());
            Console.WriteLine($"Qual o preço do produto?");
            float precoProduto = float.Parse(Console.ReadLine());
            Console.WriteLine($"Qual o código da marca?");
            int codigoMarca = int.Parse(Console.ReadLine());
            Marca marca = Marca.IdentificadorMarca(codigoMarca);

            CadastradoPor = CadastradoPor.IdentificadorUsuario("andre");
            ListaDeProdutos.Add(new Produto(nomeProduto, codigoProduto, precoProduto, marca, CadastradoPor));
        }
        public void Listar()
        {

            Console.WriteLine($"Lista de produtos cadastrados:");
            foreach (var item in ListaDeProdutos)
            {
                Console.WriteLine(@$"
Nome:               {item.NomeProduto}
Codigo:             {item.Codigo}
Preço:              {item.Preco:C}
Data do cadastro:   {item.DataCadastro}
+++++++++++++++++++++++++++++++++++++++
Marca
Nome:               {item.Marca.NomeMarca}
Codigo:             {item.Marca.Codigo}
+++++++++++++++++++++++++++++++++++++++
Cadastrado por:     {item.CadastradoPor.Nome}
Email               {item.CadastradoPor.Email}
"); 
            }

        }
        public string Deletar()
        {
            Console.WriteLine($"Insira o código do produto a ser deletado.");
            int _codigo = int.Parse(Console.ReadLine());
            Produto produtodeletado = ListaDeProdutos.Find(z => z.Codigo == _codigo);
            int index = ListaDeProdutos.IndexOf(produtodeletado);
            ListaDeProdutos.RemoveAt(index);
            CorAmarela("Produto Deletado");
            return "";
        }
    }
}