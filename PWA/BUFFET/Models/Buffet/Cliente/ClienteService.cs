using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BUFFET.Data;
using Microsoft.EntityFrameworkCore;

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
        
        public ICollection<ClienteEntity> ObterTodos()
        {
            return _dataBaseContext.Cliente.Include(g => g.Nome)
                .ToList();
        }

        public ClienteEntity Adicionar(ClienteEntity c)
        {
            var novoCliente = c;
            _dataBaseContext.Cliente.Add(novoCliente);
            _dataBaseContext.SaveChanges();

            return novoCliente;
        }
        
    }
}