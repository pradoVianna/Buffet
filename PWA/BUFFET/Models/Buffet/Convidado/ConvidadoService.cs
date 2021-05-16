using System.ComponentModel.DataAnnotations;
using BUFFET.Data;

namespace BUFFET.Models.Buffet.Convidado
{
    public class ConvidadoService
    {
        private readonly DataBaseContext _dataBaseContext;
        [Key]public int Id { get; set; }
        public ConvidadoService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
    }
}