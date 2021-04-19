using BUFFET.Models.Buffet.Access;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BUFFET.Data
{
    public class DataBaseContext : IdentityDbContext<Usuario, UsuarioPapel, int>
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }
    }
}