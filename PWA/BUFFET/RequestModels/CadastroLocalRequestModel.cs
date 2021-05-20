using System.Collections.Generic;
using BUFFET.Models.Buffet.Evento;

namespace BUFFET.RequestModels
{
    public class CadastroLocalRequestModel : IDadosBasicos
    {
        public string Descricao { get; set; }
        public string Endereco { get; set; }
 
        
        
        public ICollection<string> ValidarEFiltrar()
        {
            var listaDeErros = new List<string>();

            return listaDeErros;
        }
    }
}