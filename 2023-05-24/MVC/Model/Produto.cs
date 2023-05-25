using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        // Caminho da pasta e do arquivo definido
        private const string PATH = "Database/Produto.csv";
        private const string txt = "Texto.txt";

        // Construtor
        public Produto()
        {
            string pasta = PATH.Split("/")[0]; // database

            // Se não existir uma pasta database, então cria-se uma
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            // se não existir um arquivo csv no caminho, então cria-se um
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
                File.Create(txt);
            }
        }
        public List<Produto> Ler()
        {
            // instanciar uma lista de produto
            List<Produto> listProdutos = new List<Produto>();

            // Criando um array de string que recebe cada linha do csv
            string[] linhas = File.ReadAllLines(PATH);

            // Para a leitura das linhas
            foreach (string item in linhas)
            {
                // Antes do split
                // 001;Coca;6;50

                // Array que recebe os itens da linha separado por ";"
                string[] atributos = item.Split(";");

                // Após o split
                // Atributo[0] = "001"
                // Atributo[1] = "Coca"
                // Atributo[2] = "6,50"

                // Instancia de objeto Produto
                Produto p = new Produto();

                // Atribuir o sdados dentro de um objeto
                p.Codigo = int.Parse(atributos[0]); //001
                p.Nome = atributos [1]; //"Coca"
                p.Preco = float.Parse(atributos[2]); //6.50f
                listProdutos.Add(p);
            }
            // retorna a lista de produtos
            return listProdutos;
        }
        // Método para preparar a linha do csv
        public string PreparaLinhaCSV(Produto _p)
        {
            return$"{_p.Codigo};{_p.Nome};{_p.Preco}";
        }

        // Método para inserir um produto no arquivo CSV
        public void Inserir(Produto _p)
        {
            string[] linhas = {PreparaLinhaCSV(_p)};

            File.AppendAllLines(PATH, linhas);
        }
    }
}