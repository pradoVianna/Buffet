using System.Collections.Generic;
using BUFFET.Models.Buffet.Cliente;

namespace BUFFET.RequestModels
{
    public class CadClienteRequestModel : IDadosBasicosClienteModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
        public string Endereco { get; set; }
        public string Obs { get; set; }
        public string DataNasc { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }

        public ICollection<string> ValidarEFiltrar()
        {
            var listaDeErros = new List<string>();
            return listaDeErros;
        }
    }
}