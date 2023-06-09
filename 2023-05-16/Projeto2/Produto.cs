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

        public string NomeProduto { get; set; }
        public int Codigo { get; set; }
        public float Preco { get; set; }
        public List<Produto> ListaDeProdutos = new List<Produto>();
        public DateTime DataCadastro { get; set; }
        public Marca Marca { get; set; }        
        public Usuario CadastradoPor { get; set; }
        // public Produto()
        // {
        // }
        // public Produto(string _nomeProduto, int _codigoProduto, float _precoProduto, Marca _marca, Usuario _usuario)
        // {
        //     NomeProduto = _nomeProduto;
        //     Codigo = _codigoProduto;
        //     Preco = _precoProduto;
        //     DataCadastro = DateTime.Now;
        //     Marca = _marca;
        //     CadastradoPor = _usuario;
        // }
        // public void teste()
        // {
        //     Marca = ObjetoMarca;
        // }

        Marca m = new Marca();
        public void Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Vamos cadastrar o produto!");

            Console.WriteLine($"Qual o nome do produto?");
            novoProduto.NomeProduto = Console.ReadLine();


            Console.WriteLine($"Qual o código do produto (apenas números)");
            novoProduto.Codigo = int.Parse(Console.ReadLine());


            Console.WriteLine($"Qual o preço do produto?");
            novoProduto.Preco = float.Parse(Console.ReadLine());
            novoProduto.DataCadastro = DateTime.Now.Date;

            novoProduto.Marca = m.Cadastrar();


            ListaDeProdutos.Add(novoProduto);            

            // CadastradoPor = CadastradoPor.IdentificadorUsuario("andre");
            // ListaDeProdutos.Add(new Produto(nomeProduto, codigoProduto, precoProduto, marca, CadastradoPor));
        }
        public void Listar()
        {

            Console.WriteLine($"Lista de produtos cadastrados:");
            foreach (var item in ListaDeProdutos)
            {
                Console.WriteLine(@$"
Produto
Nome:               {item.NomeProduto}
Codigo:             {item.Codigo}
Preço:              {item.Preco:C}
Data do cadastro:   {item.DataCadastro}
+++++++++++++++++++++++++++++++++++++++
Marca
Nome:               {item.Marca.NomeMarca}
Codigo:             {item.Marca.Codigo}
Data do Cadastro    {item.Marca.DataCadastro}
+++++++++++++++++++++++++++++++++++++++

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