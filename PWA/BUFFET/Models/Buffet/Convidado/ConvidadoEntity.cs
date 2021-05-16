using System;
using System.ComponentModel.DataAnnotations;
using BUFFET.Models.Buffet.Evento;

namespace BUFFET.Models.Buffet.Convidado
{
    public class ConvidadoEntity
    {
        public ConvidadoEntity()
        {
        }

        public ConvidadoEntity(string nome, string email, string cpf, DateTime dataNasc, EventoEntity eventoRelacionado, ConvidadoSituation situacao, string obs, DateTime dataIn, DateTime dataLast)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            DataNasc = dataNasc;
            EventoRelacionado = eventoRelacionado;
            Situacao = situacao;
            Obs = obs;
            DataIn = dataIn;
            DataLast = dataLast;
        }

        public ConvidadoEntity(int id, string nome, string email, string cpf, DateTime dataNasc, EventoEntity eventoRelacionado, ConvidadoSituation situacao, string obs, DateTime dataIn, DateTime dataLast)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CPF = cpf;
            DataNasc = dataNasc;
            EventoRelacionado = eventoRelacionado;
            Situacao = situacao;
            Obs = obs;
            DataIn = dataIn;
            DataLast = dataLast;
        }

        [Key]public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public EventoEntity EventoRelacionado { get; set; }
        public ConvidadoSituation Situacao { get; set; }
        public string Obs { get; set; }
        public DateTime DataIn { get; set; }
        public DateTime DataLast { get; set; }
    }
}