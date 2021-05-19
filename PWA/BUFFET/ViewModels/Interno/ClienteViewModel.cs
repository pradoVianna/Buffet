using System.Collections.Generic;
using BUFFET.Models.Buffet.Cliente;

namespace BUFFET.ViewModels.Interno
{
    public class ClienteViewModel
    {
        public ICollection<Cliente> Clientes { get; set; }

        public string MensagemErro { get; set; }
        public string MensagemSucesso { get; set; }
        public ClienteViewModel()
        {
            Clientes = new List<Cliente>();
        }
    }

    public class Cliente
    {
        public string Id { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Obs { get; set; }
        public string DataIn { get; set; }
        public string DataLast { get; set; }
        public string Cpf { get; set; }
        public string DataNasc { get; set; }
        public string Cnpj { get; set; }
    }
}