using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using BUFFET.Models.Buffet.Cliente;
using BUFFET.RequestModels;
using BUFFET.ViewModels.Interno;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BUFFET.Controllers
{
    [Authorize]
    public class InternoController : Controller
    {
        private readonly ClienteService _clienteService;
        // GET
        public InternoController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

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
        public IActionResult CadEvento()
        {
            return View();
        }
        public IActionResult Locais()
        {
            return View();
        }
        public IActionResult CadLocal()
        {
            return View();
        }
        
        
        
    }
}