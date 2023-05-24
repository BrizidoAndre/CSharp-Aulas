using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Model
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public float Preco { get; private set; }
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
    }
}