using System.ComponentModel.DataAnnotations;
using BUFFET.Data;

namespace BUFFET.Models.Buffet.Cliente
{
    public class ClienteService
    {
        private readonly DataBaseContext _dataBaseContext;
        [Key]public int Id { get; set; }
        public ClienteService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
    }
}