using Produto_Interface;
Console.Clear();
// Instanciando classe carrinho
Carrinho carrinho = new Carrinho();

Produto p1 = new Produto(1, "Call of Duty", 480f);
Produto p2 = new Produto(2, "Mineirinho Ultra Adventures", 2.30f);
Produto p3 = new Produto(3, "The Last of Us", 150f);

// Adicionar
carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

// Listar
carrinho.Listar();

// valor do carrinho
carrinho.ValorTotal();

carrinho.Remover(p1);

// Listar
carrinho.Listar();

// Valor Total apos remover um objeto
carrinho.ValorTotal();

// Atualizar
// Criar um novo objeto com dados atualizados
Produto produtoatualizado = new Produto();
produtoatualizado.Nome = "Mineirinho Directors Cut";
produtoatualizado.Preco = 2.50f;

carrinho.Atualizar(2, produtoatualizado);

carrinho.Listar();

carrinho.ValorTotal();
