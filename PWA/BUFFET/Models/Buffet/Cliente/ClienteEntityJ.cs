using System;

namespace BUFFET.Models.Buffet.Cliente
{
    public class ClienteEntityJ : ClienteEntity
    {
        public ClienteEntityJ()
        {
            this.Tipo = new ClienteType(EClienteDescricao.JURIDICA);
            this.Id = new Guid();
        }

        public string CNPJ { get; set; }
    }
}