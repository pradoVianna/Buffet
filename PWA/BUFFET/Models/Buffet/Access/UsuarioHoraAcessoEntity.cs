using System;
using System.ComponentModel.DataAnnotations;

namespace BUFFET.Models.Buffet.Access
{
    public class UsuarioHoraAcessoEntity
    {
        [Key]public int Id { get; set; }
        public DateTime DataAcesso { get; set; }
        public Usuario Usuario { get; set; }

        public UsuarioHoraAcessoEntity()
        {
        }

        public UsuarioHoraAcessoEntity(int id, DateTime dataAcesso, Usuario usuario)
        {
            Id = id;
            DataAcesso = dataAcesso;
            Usuario = usuario;
        }
    }
}