using System.Collections.Generic;

namespace BUFFET.ViewModels.Internal
{
    public class LocaisViewModel
    {
        public ICollection<Local> Local { get; set; }

        public LocaisViewModel()
        {
            Local = new List<Local>();
        }
    }







    public class Local
    {
        public string Id { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }


       
    }
}