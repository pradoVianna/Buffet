
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using BUFFET.Models.Buffet.Evento;
using BUFFET.ViewModels.Internal;

using BUFFET.Models.Buffet.Cliente;
using BUFFET.RequestModels;
using BUFFET.ViewModels.Interno;
 using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BUFFET.Controllers
{
    [Authorize]
    public class InternoController : Controller
    {

        private readonly EventoLocalService _eventoLocalService;
        
        private readonly ClienteService _clienteService;

        public InternoController(EventoLocalService eventoLocalService,ClienteService clienteService)
        {
            _eventoLocalService = eventoLocalService;
            _clienteService = clienteService;
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
            return View();
        }
        
        //listar::cliente
        public IActionResult Cliente()
        {
            var viewModel = new ClienteViewModel();

            var listaClientes = _clienteService.ObterTodos();

            foreach (ClienteEntity clienteEntity in listaClientes)
            {
                
            }
            
            return View(viewModel);
        }
        //add::cliente
        public IActionResult CadCliente()
        {
            return View();
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
                    Id = eventoLocal.Descricao.ToString(),
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
        
        
    }
}