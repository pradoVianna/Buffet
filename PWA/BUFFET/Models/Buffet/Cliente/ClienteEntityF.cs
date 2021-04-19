using System;
using System.Runtime.CompilerServices;

namespace BUFFET.Models.Buffet.Cliente
{
    public class ClienteEntityF: ClienteEntity
    {
        
        public ClienteEntityF()
        {
            this.Tipo = new ClienteType(EClienteDescricao.FISICA);
        }

        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
    }
}