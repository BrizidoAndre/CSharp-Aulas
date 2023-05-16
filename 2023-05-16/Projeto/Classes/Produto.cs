namespace Projeto.Classes
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Marca Marca { get; private set; }
        public Usuario CadastradoPor { get; private set; }
        public List<Produto> ListaDeProdutos { get; private set; }
        public string Cadastrar(Produto _produto)
        {
            
        }
        public List<Produto> Listar()
        {

        }
        public string Deletar(Produto _produto)
        {

        }
    }
}