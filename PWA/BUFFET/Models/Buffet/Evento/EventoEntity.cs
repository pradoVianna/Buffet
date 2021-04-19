using System;
using BUFFET.Models.Buffet.Cliente;

namespace BUFFET.Models.Buffet.Evento
{
    public class EventoEntity
    {
        
        public EventoEntity()
        {
        }

        public EventoEntity(EventoType tipo, string descricao, DateTime dataHoraInicial, DateTime dataHoraFinal, ClienteEntity clienteResponsavel, EventoLocal local, EventoSituation situtacao, string obs, DateTime dataIn, DateTime dataLast)
        {
            Tipo = tipo;
            Descricao = descricao;
            DataHoraInicial = dataHoraInicial;
            DataHoraFinal = dataHoraFinal;
            ClienteResponsavel = clienteResponsavel;
            Local = local;
            Situtacao = situtacao;
            Obs = obs;
            DataIn = dataIn;
            DataLast = dataLast;
        }
        public EventoType Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHoraInicial  { get; set; }
        public DateTime DataHoraFinal { get; set; }
        public ClienteEntity ClienteResponsavel { get; set; }
        public EventoLocal Local { get; set; }
        public EventoSituation Situtacao { get; set; }
        public string Obs { get; set; }
        public DateTime DataIn { get; set; }
        public DateTime DataLast { get; set; }

        
    }
}