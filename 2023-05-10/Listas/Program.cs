using Listas;

// Instanciando a lista de objetos 
List<Produto> listProdutos = new List<Produto>();

// Inserindo objetos de produtos dentro da função
listProdutos.Add(
    new Produto("CAMISETA", "200", 39.99f)
);

// Criando o produto e depois adicionando-o
Produto casaco = new Produto("CASACO", "222", 60.00f);
listProdutos.Add(casaco);

// Ler os elementos
foreach (var item in listProdutos)
{
    Console.WriteLine(@$"
    Nome:   {item.Nome}
    Código: {item.Codigo}
    Preço:       {item.Preco:C}");
    
}

// UPDATE

// acessar um ojeto da lista para manipulá-lo
Produto produtobuscado = listProdutos.Find(z => z.Codigo == "222");

// encontrar o índice do produto encontrado
int index = listProdutos.IndexOf(produtobuscado);

// exibir o índice no console
Console.WriteLine(index);

// fazer alterações
produtobuscado.Preco = 200f;

// remover antigo item da lista
listProdutos.RemoveAt(index);

// devolver o item atualizado no lugar
listProdutos.Insert(index, produtobuscado);
foreach (var item in listProdutos)
{
    Console.WriteLine(@$"
    Nome:   {item.Nome}
    Código: {item.Codigo}
    Preço:       {item.Preco:C}");
    
}