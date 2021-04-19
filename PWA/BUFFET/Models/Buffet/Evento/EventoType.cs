namespace BUFFET.Models.Buffet.Evento
{
    public class EventoType
    {
        public int Id { get; set; }
        public EEventoDescricao Descricao { get; set; }
    }

    public enum EEventoDescricao
    {
        CASAMENTO,
        ANIVERSARIO,
        EVENTO_SOCIAL,
        OUTROS
    }
}