using BUFFET.Data;

namespace BUFFET.Models.Buffet.Convidado
{
    public class ConvidadoService
    {
        private readonly DataBaseContext _dataBaseContext;

        public ConvidadoService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
    }
}