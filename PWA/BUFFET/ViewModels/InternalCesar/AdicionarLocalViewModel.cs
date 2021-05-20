using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BUFFET.ViewModels.Internal
{
    public class AdicionarLocalViewModel
    {
        public string[] FormMensagensErro { get; set; }
        public ICollection<SelectListItem> EventoLocal { get; set; }

        public AdicionarLocalViewModel()
        {
            EventoLocal = new List<SelectListItem>
            {
                new SelectListItem("Selecione Local", "")
            };
        }
     
     
        
    }
}