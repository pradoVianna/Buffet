using Microsoft.AspNetCore.Identity;

namespace BUFFET.Models.Buffet.Access
{
    public class Usuario : IdentityUser<int>
    {
        public Usuario()
        {
        }

        //public int Id { get; set; }
        //public string Nome { get; set; }
        //public string Senha { get; set; }
        //public string Email { get; set; }
    }
}