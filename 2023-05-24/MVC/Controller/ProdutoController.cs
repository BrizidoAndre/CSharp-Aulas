using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}