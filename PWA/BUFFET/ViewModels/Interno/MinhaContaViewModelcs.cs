using System.Collections.Generic;
using BUFFET.Models.Buffet.Access;

namespace BUFFET.ViewModels.Internal
{
    public class MinhaContaViewModel
    {
        public ICollection<UsuarioHoraAcessoEnt> UsuarioHoraAcessoEnt { get; set; }

        public MinhaContaViewModel()
        {
            UsuarioHoraAcessoEnt = new List<UsuarioHoraAcessoEnt>();
        }
    }







    public class UsuarioHoraAcessoEnt
    {
        public string Id { get; set; }
        public string DataAcesso { get; set; }
        public Usuario Usuario { get; set; }


       
    }
}