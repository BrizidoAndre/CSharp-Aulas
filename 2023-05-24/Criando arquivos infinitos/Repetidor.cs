using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Criando_arquivos_infinitos
{
    public class Repetidor
    {
        public string Arquivo { get; private set; } = "Pasta/Arquivo";
        public int Numerador { get; private set; } = 1;
        public string NomeArquivo { get; private set; }
        public void CriandoArquivo()
        {
            Directory.CreateDirectory(Arquivo.Split("/")[0]);
            do
            {
                NomeArquivo = Arquivo + Numerador.ToString();
                File.Create(NomeArquivo);
                Numerador +=1;
            } while (true);
        }
    }
}