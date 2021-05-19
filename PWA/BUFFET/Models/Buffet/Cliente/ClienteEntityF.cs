using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace BUFFET.Models.Buffet.Cliente
{
    public class ClienteEntityF: ClienteEntity
    {
        
        public ClienteEntityF():base()
        {
            
            this.Tipo = new ClienteType(EClienteDescricao.FISICA);
            this.DataIn = DateTime.Now;
        }

        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
    }
}