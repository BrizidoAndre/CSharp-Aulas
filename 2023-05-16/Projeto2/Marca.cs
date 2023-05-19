using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        public static List<Marca> ListaMarca = new List<Marca>();
        public Marca()
        {
        }
        public Marca(string _nomeMarca, int _codigoMarca)
        {
            NomeMarca = _nomeMarca;
            Codigo = _codigoMarca;
            DataCadastro = DateTime.Now;
        }
        public List<Marca> Listar()
        {
            foreach (var item in ListaMarca)
            {
                Console.WriteLine(@$"
            Codigo:           {item.Codigo}
            Nome da Marca:    {item.NomeMarca}
            Data do Cadastro  {item.DataCadastro}
            ");
            }
            return ListaMarca;
        }
        public Marca Cadastrar()
        {
            Marca novaMarca = new Marca();

            Console.WriteLine($"Insira o codigo da marca (apenas números)");
            novaMarca.Codigo = int.Parse(Console.ReadLine());
            Marca marcabuscada = ListaMarca.Find(z => z.Codigo == novaMarca.Codigo);

            if (marcabuscada == null)
            {
                Console.WriteLine($"Agora insira o nome da marca");
                novaMarca.NomeMarca = Console.ReadLine();
                novaMarca.DataCadastro = DateTime.Now.Date;
                ListaMarca.Add(novaMarca);
                return (novaMarca);
            }
            else
            {
                Console.WriteLine($"O objeto já existe!");
                Console.WriteLine($"Marca:              {marcabuscada.NomeMarca}");
                Console.WriteLine($"Código:             {marcabuscada.Codigo}");
                Console.WriteLine($"Data do cadastro    {marcabuscada.DataCadastro}");
                return marcabuscada;
            }
        }
        public string Deletar()
        {
            Marca _marca;
            Console.WriteLine($"Por favor insira o código da marca (apenas números)");
            int codigoDaMarca = int.Parse(Console.ReadLine());
            _marca = ListaMarca.Find(z => z.Codigo == codigoDaMarca);
            int index = ListaMarca.IndexOf(_marca);
            ListaMarca.RemoveAt(index);
            return "Produto deletado!";
        }
    }
}