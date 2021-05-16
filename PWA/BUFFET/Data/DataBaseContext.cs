using BUFFET.Models.Buffet.Access;
using BUFFET.Models.Buffet.Cliente;
using BUFFET.Models.Buffet.Convidado;
using BUFFET.Models.Buffet.Evento;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BUFFET.Data
{
    public class DataBaseContext : IdentityDbContext<Usuario, UsuarioPapel, int>
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<ClienteEntityF> ClienteF{ get; set; }
        public DbSet<ClienteEntityJ> ClienteJ { get; set; }
        public DbSet<ClienteService> ClienteService { get; set; }
        public DbSet<ClienteType> ClienteType { get; set; }
        public DbSet<ConvidadoEntity> Convidado { get; set; }
        public DbSet<ConvidadoService> ConvidadoService { get; set; }
        public DbSet<ConvidadoSituation> ConvidadoSituation { get; set; }
        public DbSet<EventoEntity> Evento { get; set; }
        public DbSet<EventoLocal> EventoLocal { get; set; }
        public DbSet<EventoService> EventoService { get; set; }
        public DbSet<EventoSituation> EventoSituation { get; set; }
        public DbSet<EventoType> EventoType { get; set; }
        
        
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }
    }
}