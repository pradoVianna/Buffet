using BUFFET.Data;

namespace BUFFET.Models.Buffet.Access
{
    public class UsuarioService
    {
        private readonly DataBaseContext _dataBaseContext;

        public UsuarioService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        
        
    }
}