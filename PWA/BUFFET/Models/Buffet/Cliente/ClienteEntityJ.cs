namespace BUFFET.Models.Buffet.Cliente
{
    public class ClienteEntityJ : ClienteEntity
    {
        public ClienteEntityJ()
        {
            this.Tipo = new ClienteType(EClienteDescricao.JURIDICA);
        }

        public string CNPJ { get; set; }
    }
}