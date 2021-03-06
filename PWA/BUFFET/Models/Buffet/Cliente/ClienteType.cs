using System.ComponentModel.DataAnnotations;

namespace BUFFET.Models.Buffet.Cliente
{
    public class ClienteType
    {
        [Key]public int Id { get; set; }
        public EClienteDescricao Descricao { get; set; }

        public ClienteType(EClienteDescricao descricao)
        {
            Descricao = descricao;
        }
    }
    
    public enum EClienteDescricao
    {
        FISICA,JURIDICA
    }
}