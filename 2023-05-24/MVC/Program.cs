using MVC.Model;
using MVC.Controller;
// Instancia
Produto p = new Produto();
ProdutoController pController = new ProdutoController();

pController.CadastrarProduto();
pController.ListarProdutos();