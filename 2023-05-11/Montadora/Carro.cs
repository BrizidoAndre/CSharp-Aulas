using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public Carro()
        {

        }
        public Carro(string _modelo, string _cor)
        {
            this.Modelo = _modelo;
            this.Cor = _cor;
        }
        public void Teste()
        {

        }
    }
}