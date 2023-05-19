using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Login
    {
        public bool Logado { get; private set; }
        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public Login(bool _logado)
        {
            
        }
        public void Logon(bool _logado)
        {
            Logado = _logado;
        }
        public bool Deslogar()
        {
            return false;
        }
    }
}