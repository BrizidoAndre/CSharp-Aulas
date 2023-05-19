using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Marca
    {

        static void CorAmarela(string texto)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(texto);
            Console.ResetColor();

        }
        static void CorVerde(string texto)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(texto);
            Console.ResetColor();

        }

        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; }
        List<Marca> ListaMarca = new List<Marca>();
        public Marca()
        {
        }
        public Marca(string _nomeMarca, int _codigoMarca)
        {
            NomeMarca = _nomeMarca;
            Codigo = _codigoMarca;
            DataCadastro = DateTime.Now;
            ListaMarca = new List<Marca>();
        }
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
        public string Cadastrar()
        {
            Console.WriteLine($"Por favor insira o nome da marca:");
            string nomeDaMarca = Console.ReadLine();
            Console.WriteLine($"Agora insira o codigo da marca (apenas números)");
            int codigoDaMarca = int.Parse(Console.ReadLine());
            ListaMarca.Add(
                new Marca(nomeDaMarca, codigoDaMarca)
            );
            return "Marca registrada!";
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
        public Marca IdentificadorMarca(int _codigo)
        {
            Marca marca = ListaMarca.Find(z => z.Codigo == _codigo);
            if (marca == null)
            {
                Console.WriteLine($"Digite o nome da marca");
                this.NomeMarca = Console.ReadLine();
                CorVerde("Nome registrado!");
                this.DataCadastro = DateTime.Now;
                this.Codigo = _codigo;
                ListaMarca.Add(
                    new Marca(NomeMarca, Codigo)
                );
                return marca;
            }
            else
            {
                Console.WriteLine($"{marca.NomeMarca} {marca.DataCadastro} {marca.Codigo}");   
                Console.WriteLine($"A marca já existe");
                return marca;
            }


        }
    }
}