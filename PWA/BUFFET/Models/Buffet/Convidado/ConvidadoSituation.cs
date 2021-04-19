namespace BUFFET.Models.Buffet.Convidado
{
    public class ConvidadoSituation
    {
        public ConvidadoSituation()
        {
        }

        public int Id { get; set; }
        public EConvidadoSituacao Descricao { get; set; }
    }

    public enum EConvidadoSituacao
    {
        CONFIRMADO,
        CANCELADO,
        EM_DUVIDA,
        OUTROS
    }
}