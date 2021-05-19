using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BUFFET.Data;
using Microsoft.EntityFrameworkCore;

namespace BUFFET.Models.Buffet.Cliente
{
    public class ClienteService
    {
        [Key]public int Id { get; set; }
        
        private readonly DataBaseContext _dataBaseContext;
        public ClienteService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }


        public ICollection<ClienteEntity> ObterTodos()
        {
            return _dataBaseContext.Cliente.Include(c => c.Tipo).ToList();
        }
       
        
    }
}