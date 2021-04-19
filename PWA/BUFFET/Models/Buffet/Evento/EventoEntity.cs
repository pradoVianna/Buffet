using System;
using BUFFET.Models.Buffet.Cliente;

namespace BUFFET.Models.Buffet.Evento
{
    public class EventoEntity
    {
        public EventoType Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHoraInicial  { get; set; }
        public DateTime DataHoraFinal { get; set; }
        public ClienteEntity ClienteResponsavel { get; set; }
        public EventoLocal Local { get; set; }
        public EventoSituation Situtacao { get; set; }
        
    }
}