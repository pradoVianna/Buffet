using BUFFET.Models.Buffet.Access;
using Microsoft.EntityFrameworkCore;

namespace BUFFET.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }
    }
}