using System.ComponentModel.DataAnnotations;
using BUFFET.Data;

namespace BUFFET.Models.Buffet.Evento
{
    public class EventoService
    {
        private readonly DataBaseContext _dataBaseContext;
        [Key]public int Id { get; set; }
        public EventoService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
    }
}