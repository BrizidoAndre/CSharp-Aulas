using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_Interface
{
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; } //Esse e o valor
        List<Produto> carrinho = new List<Produto>();

        // Implementar a logica para cada método
        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
            
        }

        public void Listar()
        {
            if (carrinho.Count > 0 || carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine($"Código: {p.Codigo}");
                    Console.WriteLine($"Nome:   {p.Nome}");
                    Console.WriteLine($"Preço:  {p.Preco:C}");     
                }
            }
            else
            {
                Console.WriteLine($"A lista está vazia");
            }
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }
        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }
        
        public void ValorTotal()
        {
            this.Valor = 0;
            if (carrinho.Count > 0 || carrinho != null)
            {
                foreach (var item in carrinho)
                {
                   Valor += item.Preco;
                }
                Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine($"O valor total do carrinho e de {Valor:C}");
                Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++");
                
            }
        }
    }
}