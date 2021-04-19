namespace BUFFET.Models.Buffet.Evento
{
    public class EventoSituation
    {
        public EventoSituation()
        {
        }

        public int Id { get; set; }
        public EEventoSituacao Descricao { get; set; }
    }

    public enum EEventoSituacao
    {
        AGENDADO,
        CANCELADO,
        EXECUTADO,
        OUTROS
    }
}