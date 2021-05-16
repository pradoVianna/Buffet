using System.ComponentModel.DataAnnotations;

namespace BUFFET.Models.Buffet.Evento
{
    public class EventoLocal
    {
        public EventoLocal()
        {
        }
        
        [Key]public int Id { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
    }
}