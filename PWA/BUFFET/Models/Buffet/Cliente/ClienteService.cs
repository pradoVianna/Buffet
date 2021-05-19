using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BUFFET.Data;
using Microsoft.EntityFrameworkCore;

namespace BUFFET.Models.Buffet.Cliente
{
    public class ClienteService
    {
        [Key]public int Id { get; set; }
        
        private readonly DataBaseContext _dataBaseContext;
        public ClienteService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }


        public ICollection<ClienteEntity> ObterTodos()
        {
            return _dataBaseContext.Cliente.Include(c => c.Tipo).ToList();
        }

        public ClienteEntity ObterPorId(int id)
        {
            try
            {
                return _dataBaseContext.Cliente.Include(c => c.Tipo).First(c => c.Id == id);
            }
            catch
            {
                throw new Exception("Cliente de ID #" + id + " não encontrado");
            }
        }
        
        public ClienteEntity Adicionar(IDadosBasicosClienteModel dadosBasicos)
        {
            var novoCliente = Validador(dadosBasicos);
            if (novoCliente.Tipo.Descricao == EClienteDescricao.FISICA)
            {
                _dataBaseContext.ClienteF.Add(novoCliente as ClienteEntityF);
                _dataBaseContext.SaveChanges();
            }
            else
            {
                _dataBaseContext.ClienteJ.Add(novoCliente as ClienteEntityJ);
                _dataBaseContext.SaveChanges();
            }

            return novoCliente;
        }
        public ClienteEntity Editar(int id,IDadosBasicosClienteModel dadosBasicos)
        {
            var clienteExistente = ObterPorId(id);
            clienteExistente = Validador(dadosBasicos, clienteExistente);
            _dataBaseContext.SaveChanges();
            return clienteExistente;

        }

        private ClienteEntity Validador(IDadosBasicosClienteModel dadosBasicos, ClienteEntity clienteExistente = null)
        {
            
            if (clienteExistente != null)
            {
                
                if (clienteExistente.Tipo.Descricao == EClienteDescricao.FISICA)
                { 
                  var  entidade = clienteExistente as ClienteEntityF;
                entidade.Tipo.Descricao = EClienteDescricao.FISICA;
                if (dadosBasicos.Cpf == null)
                {
                    throw new Exception("Documento obrigatório");
                }

                entidade.CPF = dadosBasicos.Cpf;
                if (dadosBasicos.DataNasc == null)
                {
                    throw new Exception("Data Nascimento obrigatória");
                }

                entidade.DataNasc = Convert.ToDateTime(dadosBasicos.DataNasc);
                if (dadosBasicos.Nome == null)
                {
                    throw new Exception("Nome obrigatório");
                }

                entidade.Nome = dadosBasicos.Nome;
                if (dadosBasicos.Email == null)
                {
                    throw new Exception("E-mail obrigatório");
                }

                entidade.Email = dadosBasicos.Email;
                if (dadosBasicos.Endereco == null)
                {
                    throw new Exception("Endereço obrigatório");
                }

                entidade.Endereco = dadosBasicos.Endereco;
                if (dadosBasicos.Obs == null)
                {
                    throw new Exception("Observações obrigatória");
                }

                entidade.Obs = dadosBasicos.Obs;
                return entidade;
            }
            else
            {
                var  entidade = clienteExistente as ClienteEntityJ;
                entidade.Tipo.Descricao = EClienteDescricao.JURIDICA;
                if (dadosBasicos.Cnpj == null)
                {
                    throw new Exception("Documento obrigatório");
                }

                entidade.CNPJ = dadosBasicos.Cnpj;
                if (dadosBasicos.Nome == null)
                {
                    throw new Exception("Nome obrigatório");
                }

                entidade.Nome = dadosBasicos.Nome;
                if (dadosBasicos.Email == null)
                {
                    throw new Exception("E-mail obrigatório");
                }

                entidade.Email = dadosBasicos.Email;
                if (dadosBasicos.Endereco == null)
                {
                    throw new Exception("Endereço obrigatório");
                }

                entidade.Endereco = dadosBasicos.Endereco;
                if (dadosBasicos.Obs == null)
                {
                    throw new Exception("Observações obrigatória");
                }

                entidade.Obs = dadosBasicos.Obs;


                return entidade;
            }
                
            }
            else if (dadosBasicos.Tipo == "FISICA")
            {
                var entidade = new ClienteEntityF();
                entidade.Tipo.Descricao = EClienteDescricao.FISICA;
                if (dadosBasicos.Cpf == null)
                {
                    throw new Exception("Documento obrigatório");
                }

                entidade.CPF = dadosBasicos.Cpf;
                if (dadosBasicos.DataNasc == null)
                {
                    throw new Exception("Data Nascimento obrigatória");
                }

                entidade.DataNasc = Convert.ToDateTime(dadosBasicos.DataNasc);
                if (dadosBasicos.Nome == null)
                {
                    throw new Exception("Nome obrigatório");
                }

                entidade.Nome = dadosBasicos.Nome;
                if (dadosBasicos.Email == null)
                {
                    throw new Exception("E-mail obrigatório");
                }

                entidade.Email = dadosBasicos.Email;
                if (dadosBasicos.Endereco == null)
                {
                    throw new Exception("Endereço obrigatório");
                }

                entidade.Endereco = dadosBasicos.Endereco;
                if (dadosBasicos.Obs == null)
                {
                    throw new Exception("Observações obrigatória");
                }

                entidade.Obs = dadosBasicos.Obs;
                return entidade;
            }
            else
            {
                var entidade = new ClienteEntityJ();
                entidade.Tipo.Descricao = EClienteDescricao.JURIDICA;
                if (dadosBasicos.Cnpj == null)
                {
                    throw new Exception("Documento obrigatório");
                }

                entidade.CNPJ = dadosBasicos.Cnpj;
                if (dadosBasicos.Nome == null)
                {
                    throw new Exception("Nome obrigatório");
                }

                entidade.Nome = dadosBasicos.Nome;
                if (dadosBasicos.Email == null)
                {
                    throw new Exception("E-mail obrigatório");
                }

                entidade.Email = dadosBasicos.Email;
                if (dadosBasicos.Endereco == null)
                {
                    throw new Exception("Endereço obrigatório");
                }

                entidade.Endereco = dadosBasicos.Endereco;
                if (dadosBasicos.Obs == null)
                {
                    throw new Exception("Observações obrigatória");
                }

                entidade.Obs = dadosBasicos.Obs;


                return entidade;
            }

            return null;
        }


    }

    public interface IDadosBasicosClienteModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
        public string Endereco { get; set; }
        public string Obs { get; set; }
        public string DataNasc { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
    }
}