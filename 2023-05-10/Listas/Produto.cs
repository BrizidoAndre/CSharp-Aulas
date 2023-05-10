namespace Listas
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public float Preco { get; set; }
        public Produto()
        {
        }
        public Produto(string _nome, string _codigo, float _preco)
        {
            Codigo = _codigo;
            Nome = _nome;
            Preco = _preco;
        }
    }
}