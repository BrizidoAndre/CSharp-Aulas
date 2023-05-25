using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Evento.Model;
namespace MVC_Evento.View
{
    public class EventoView
    {

        
        public EventoModel CadastrarEvento()
        {
            EventoModel novoEvento = new EventoModel();

            Console.WriteLine($"Por favor digite o nome do evento");
            novoEvento.Nome = Console.ReadLine();

            Console.WriteLine($"Agora digite a descrição do evento");
            novoEvento.Descricao = Console.ReadLine();
            
            Console.WriteLine($"Agora digite o dia do evento");
            novoEvento.DiaDoEvento = Console.ReadLine();
            
            return novoEvento;
        }


        public void Listar(List<EventoModel> _e)
        {
            foreach (var item in _e)
            {
                Console.WriteLine(@$"
Nome:           {item.Nome}
Descrição:      {item.Descricao}
Dia do Evento:  {item.DiaDoEvento}");
            }
        }
    }
}