using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BUFFET.Data;
using Microsoft.EntityFrameworkCore;

namespace BUFFET.Models.Buffet.Evento
{
    public class EventoLocalService
    {
        private readonly DataBaseContext _dataBaseContext;

        public EventoLocalService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public ICollection<EventoLocal> ListaTodos()
        {
            return _dataBaseContext.EventoLocal
                .ToList();
            
        }

        public EventoLocal Adicionar(IDadosBasicos dadosBasicos)
        {
            var novoLocal = ValidacaoDados(dadosBasicos);

            _dataBaseContext.EventoLocal.Add(novoLocal);
            _dataBaseContext.SaveChanges();

            return novoLocal;
        }
        
      /*  public EventoLocal Editar(Guid id, IDadosBasicos dadosBasicos)
        {
            return Editar();
        }*/

       /* public void ValidacaoDados(IDadosBasicos dadosBasicos, EventoLocal eventoLocalExiste = null)
        {
            var entidade = eventoLocalExiste ?? new EventoLocal();
        }*/
       
       private EventoLocal ValidacaoDados(IDadosBasicos dadosBasicos, EventoLocal eventoLocalExiste = null)
       {
           var entidade = eventoLocalExiste ?? new EventoLocal();
           

           // Validar e Atribuir Descrição
           if (dadosBasicos.Descricao == null) {
               throw new Exception("A Descrição é obrigatória");
           }

           if (dadosBasicos.Descricao.Length < 3) {
               throw new Exception("A Descrição informada deve conter pelo menos 3 caracteres");
           }

           entidade.Descricao = dadosBasicos.Descricao;
           
           // Validar e Atribuir Descrição
           if (dadosBasicos.Endereco == null) {
               throw new Exception("O endereçp é obrigatória");
           }

           if (dadosBasicos.Endereco.Length < 3) {
               throw new Exception("O endereçp informado deve conter pelo menos 3 caracteres");
           }

           entidade.Endereco = dadosBasicos.Endereco;


           return entidade;

       }
    }

    public interface IDadosBasicos
    {
        public string Descricao { get; set; }
        public string Endereco { get; set; }
    }
}