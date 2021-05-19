using System;

namespace BUFFET.Models.Buffet.Cliente
{
    public class ClienteEntityJ : ClienteEntity
    {
        public ClienteEntityJ():base()
        {
            this.Tipo = new ClienteType(EClienteDescricao.JURIDICA);
            this.DataIn = DateTime.Now;
        }

        public string CNPJ { get; set; }
    }
}