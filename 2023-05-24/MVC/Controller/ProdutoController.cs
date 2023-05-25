using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using MVC.Model;
using MVC.View;
namespace MVC.Controller
{
    public class ProdutoController
    {
        // Instanciar objeto produto e produtoView
        Produto produto = new Produto();
        ProdutoView pView = new ProdutoView();
        public void ListarProdutos()
        {
            // lista de pordutos chamada pela model
            List<Produto> produtos = produto.Ler();

            // chamado método de exibição (VIEW) recebendo como argumento a l
            pView.Listar(produtos);
        }
        public void CadastrarProduto()
        {
            // Chamada para a view que recebe cada objeto a ser inserido no csv
            Produto novoproduto = pView.Cadastrar();

            // Chamada para a model para inserir esse objeto no csv
            produto.Inserir(novoproduto);
        }
    }
}