using BUFFET.Data;

namespace BUFFET.Models.Buffet.Evento
{
    public class EventoService
    {
        private readonly DataBaseContext _dataBaseContext;

        public EventoService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
    }
}