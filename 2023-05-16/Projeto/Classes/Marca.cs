namespace Projeto.Classes
{
    public class Marca
    {
        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; }
        List<Marca> ListaMarca = new List<Marca>();
        public List<Marca> Listar()
        {
            foreach (var item in ListaMarca)
            {
                Console.WriteLine(@$"
            Codigo:           {item.Codigo}
            Nome da Marca:    {item.NomeMarca}
            Data do cadastro: {item.DataCadastro}");
            }
            return ListaMarca;
        }
        public string Cadastrar(Marca _marca)
        {
            Console.WriteLine($"Por favor insira o nome da marca:");
            string nomeDaMarca = Console.ReadLine();
            Console.WriteLine($"Agora insira o codigo da marca (apenas números)");
            int codigoDaMarca = int.Parse(Console.ReadLine());
            _marca.NomeMarca = nomeDaMarca;
            _marca.Codigo = codigoDaMarca;
            _marca.DataCadastro = DateTime.Now;
            ListaMarca.Add(
                _marca
            );
            return "Marca registrada!";
        }
        public string Deletar(Marca _marca)
        {
            Console.WriteLine($"Por favor insira o código da marca");
            int codigoDaMarca = int.Parse(Console.ReadLine());
            _marca = ListaMarca.Find(z => z.Codigo == codigoDaMarca);
            int index = ListaMarca.IndexOf(_marca);
            ListaMarca.RemoveAt(index);
            ListaMarca.Sort();
            return "Produto deletado!";
        }
    }
}