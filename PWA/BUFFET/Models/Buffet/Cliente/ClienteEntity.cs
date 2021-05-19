using System;
using System.ComponentModel.DataAnnotations;

namespace BUFFET.Models.Buffet.Cliente
{
    public class ClienteEntity
    {

        [Key]public Guid Id { get; set; }
        public ClienteType Tipo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Obs { get; set; }
        public DateTime DataIn { get; set; }
        public DateTime DataLast { get; set; }

        
    }
}