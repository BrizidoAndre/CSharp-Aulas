using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Evento;
namespace MVC_Evento.Model
{
    public class EventoModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DiaDoEvento { get; set; }
        private const string path_main = "Eventos";
        private const string path_file = "Dados.txt";
        public EventoModel()
        {
            if (!Directory.Exists(path_main))
            {
                Directory.CreateDirectory(path_main);
            }
            if (!File.Exists($"{path_main}/{path_file}"))
            {
                File.Create($"{path_main}/{path_file}");
            }
        }
        public List<EventoModel> Ler()
        {
            List<EventoModel> listaEventos = new List<EventoModel>();
            string[] linhas = File.ReadAllLines($"{path_main}/{path_file}");
            
            foreach (var item in linhas)
            {

                string[] valores = item.Split(";");
                


                EventoModel novoevento = new EventoModel();
                novoevento.Nome = valores[0];
                novoevento.Descricao = valores[1];
                novoevento.DiaDoEvento = valores[2];
                listaEventos.Add(novoevento);
            }
            return listaEventos;
        }
        public string PrepararLinhas(EventoModel _e)
        {
            return $"{_e.Nome};{_e.Descricao};{_e.DiaDoEvento}";
        }
        public void AdicionarEvento(EventoModel _e)
        {
            string[] linhas = {PrepararLinhas(_e)};
            File.AppendAllLines($"{path_main}/{path_file}",linhas);
        }

    }
}