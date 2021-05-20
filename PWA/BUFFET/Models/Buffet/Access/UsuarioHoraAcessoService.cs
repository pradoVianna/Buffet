using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BUFFET.Data;
using Microsoft.EntityFrameworkCore;

namespace BUFFET.Models.Buffet.Access
{
    public class UsuarioHoraAcessoService
    {
        [Key]public int Id { get; set; }
        
        private readonly DataBaseContext _dataBaseContext;
        
        public UsuarioHoraAcessoService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        
        public ICollection<UsuarioHoraAcessoEntity> ObterTodos()
        {
            return _dataBaseContext.UsuarioHoraAcesso.Include
                (u => u.Usuario).ToList();
        }
        
        public ICollection<UsuarioHoraAcessoEntity> ListaTodos()
        {
            return _dataBaseContext.UsuarioHoraAcesso
                .ToList();
            
        }

        public UsuarioHoraAcessoEntity ObterPorId(int id)
        {
            try
            {
                return _dataBaseContext.UsuarioHoraAcesso.Include
                    (u => u.Id).First(u => u.Id == id);
            }
            catch
            {
                throw new Exception("Usuário de ID #" + id + " não encontrado");
            }
        }
    }
}