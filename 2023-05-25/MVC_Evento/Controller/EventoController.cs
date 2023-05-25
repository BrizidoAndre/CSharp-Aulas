using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Evento.Model;
using MVC_Evento.View;

namespace MVC_Evento.Controller
{
    public class EventoController
    {
        EventoModel EM = new EventoModel();
        EventoView EV = new EventoView();

        public void Listar()
        {
            List<EventoModel> listaeventos = EM.Ler();

            EV.Listar(listaeventos);
        }
        public void CadastarEvento()
        {
            EM.AdicionarEvento(EV.CadastrarEvento());
        }
    }
}