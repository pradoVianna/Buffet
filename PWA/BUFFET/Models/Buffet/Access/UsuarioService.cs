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

        public bool LoginVerify(string email, string senha)
        {
            return false;
        }
    }
}