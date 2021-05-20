
using System;


using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using BUFFET.Models.Buffet.Evento;
using BUFFET.ViewModels.Internal;

using BUFFET.Models.Buffet.Cliente;
using BUFFET.RequestModels;

using System;

using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using BUFFET.Models.Buffet.Cliente;
using BUFFET.RequestModels;


using System.Reflection.Metadata;
using BUFFET.Models.Buffet.Access;
using BUFFET.Models.Buffet.Evento;
using BUFFET.ViewModels.Internal;


using BUFFET.Models.Buffet.Cliente;

using BUFFET.ViewModels.Interno;

using Microsoft.AspNetCore.Authorization;

using BUFFET.Models.Buffet.Cliente;

using BUFFET.ViewModels.Interno;
 using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UsuarioHoraAcessoEntity = BUFFET.Models.Buffet.Access.UsuarioHoraAcessoEntity;

namespace BUFFET.Controllers
{
    [Authorize]
    public class InternoController : Controller
    {

        private readonly EventoLocalService _eventoLocalService;

        private readonly ClienteService _clienteService;
        private readonly UsuarioService _usuarioService;
        private readonly UsuarioHoraAcessoService _usuarioHoraAcessoService;

        public InternoController(EventoLocalService eventoLocalService, ClienteService clienteService
        ,UsuarioService usuarioService, UsuarioHoraAcessoService usuarioHoraAcessoService)
        {
            _eventoLocalService = eventoLocalService;
            _clienteService = clienteService;
            _usuarioService = usuarioService;
            _usuarioHoraAcessoService = usuarioHoraAcessoService;
        }

        



        // GET
       



     
        

        public IActionResult Index()
        {
            
            
            return View();
        }
        public IActionResult TermosUso()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Ajuda()
        {
            return View();
        }
        public IActionResult Agenda()
        {
            return View();
        }
        public IActionResult Eventos()
        {
            return View();
        }
        public IActionResult Financeiro()
        {
            return View();
        }
        public IActionResult MinhaConta()
        {
            var viewModel = new MinhaContaViewModel();

            var listaAcessos = _usuarioHoraAcessoService.ListaTodos();

            foreach (UsuarioHoraAcessoEntity userHoraAces in listaAcessos)
            {
                viewModel.UsuarioHoraAcessoEnt.Add(new UsuarioHoraAcessoEnt()
                {
                    Id = userHoraAces.Id.ToString(),
                    DataAcesso = userHoraAces.DataAcesso.ToShortDateString(),
                    Usuario = userHoraAces.Usuario
                });

            }
            return View(viewModel);
            
            
        }
        
        //listar::cliente
        public IActionResult Cliente()
        {
            var viewModel = new ClienteViewModel()
            {
                MensagemErro = (string) TempData["FormMenssagemErro"],
                MensagemSucesso =(string) TempData["FormMenssagemSucesso"]
            };

            var listaClientes = _clienteService.ObterTodos();

            foreach (var clienteEntity in listaClientes)
            {
                var c = new Cliente()
                    {
                        Tipo = clienteEntity.Tipo.Descricao.ToString()
                    };
                if (c.Tipo == "FISICA")
                {
                    ClienteEntityF c2 = clienteEntity as ClienteEntityF;
                    c.Id = c2.Id.ToString();
                    c.Nome = c2.Nome;
                    c.Endereco = c2.Endereco;
                    c.Email = c2.Email;
                    c.Obs = c2.Obs;
                    c.Cpf = c2.CPF;
                    c.DataNasc = c2.DataNasc.ToShortDateString();
                    c.DataIn = c2.DataIn.ToShortDateString();
                    c.DataLast = c2.DataLast.ToShortDateString();
                    viewModel.Clientes.Add(c);
                }
                else
                {
                    ClienteEntityJ c2 = clienteEntity as ClienteEntityJ;
                    c.Id = c2.Id.ToString();
                    c.Nome = c2.Nome;
                    c.Endereco = c2.Endereco;
                    c.Email = c2.Email;
                    c.Obs = c2.Obs;
                    c.Cnpj = c2.CNPJ;
                    c.DataIn = c2.DataIn.ToShortDateString();
                    c.DataLast = c2.DataLast.ToShortDateString();
                    viewModel.Clientes.Add(c);
                }
            }
            
            return View(viewModel);
        }
        //add::cliente
        [HttpGet]
        public IActionResult CadCliente()
        {
            var viewModel = new CadClienteViewModel()
            {
                FormMessagensErro = (string[]) TempData["FormMensagensErro"]
            };
            
            
            
            return View(viewModel);
        }
        [HttpPost]
        public RedirectToActionResult CadCliente(CadClienteRequestModel requestModel)
        {

            var listaDeErros = requestModel.ValidarEFiltrar();
            if (listaDeErros.Count > 0)
            {
                TempData["FormMensagensErro"] = listaDeErros;
                return RedirectToAction("CadCliente");
            }
            
            try
            {
                _clienteService.Adicionar(requestModel);
                TempData["FormMensagemSucesso"] = "Cliente adicionado com sucesso!";
                return RedirectToAction("Cliente");
            }
            catch (Exception exception)
            {
                TempData["FormMensagemErro"] = new List<string> {exception.Message};
                return RedirectToAction("CadCliente");
            }
                
        }
        
        [HttpGet]
        public IActionResult CadEvento()
        {
            var viewModel = new AdicionarLocalViewModel();

            var locais = _eventoLocalService.ListaTodos();
            foreach (var eventoLocal in locais) {
                viewModel.EventoLocal.Add(new SelectListItem()
                {
                    Value = eventoLocal.Id.ToString(),
                    Text = eventoLocal.Descricao
                });
            }

            return View(viewModel);
            return View();
        }
        
        public IActionResult CadLocal()
        {
            return View();
        }
        
        public IActionResult Locais()
        {
            var viewModel = new LocaisViewModel();

            var listaLocais = _eventoLocalService.ListaTodos();

            foreach (EventoLocal eventoLocal in listaLocais)
            {
                viewModel.Local.Add(new Local()
                {
                    Id = eventoLocal.Id.ToString(),
                    Descricao = eventoLocal.Descricao.ToString(),
                    Endereco = eventoLocal.Endereco.ToString()
                });

            }
            return View(viewModel);
        }
        
        public IActionResult Adicionar()
        {
            return View();
        }

       [HttpPost]
        public RedirectToActionResult Adicionar(CadastroLocalRequestModel requestModel)
        {
          
            var listaDeErros = requestModel.ValidarEFiltrar();
            if (listaDeErros.Count > 0) {
                TempData["formMensagensErro"] = listaDeErros;

                return RedirectToAction("Adicionar");
            }
           
            try {
                _eventoLocalService.Adicionar(requestModel);
                TempData["formMensagemSucesso"] = "Gasto adicionado com sucesso!";

                return RedirectToAction("Locais");
            } catch (Exception exception) {
                TempData["formMensagensErro"] = new List<string> {exception.Message};

                return RedirectToAction("CadLocal");
            }
        }
    
        public IActionResult Editar()
        {
            return View();
        }
        
        public IActionResult Deletar()
        {
            return View();
        }
        
        [HttpPost]
        public RedirectToActionResult EditarUser(EditarUserRequestModel requestModel)
        {
            
            _usuarioService.Editar(User.Identity.Name,requestModel);
            return RedirectToAction("MinhaConta");
        }
        
    }
}