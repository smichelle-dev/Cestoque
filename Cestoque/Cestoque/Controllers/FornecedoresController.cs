
using Cestoque.Models;
using Cestoque.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly IFornecedoresRepositorio _fornecedoresRepositorio;
        public FornecedoresController(IFornecedoresRepositorio fornecedoresRepositorio)
        {
            _fornecedoresRepositorio = fornecedoresRepositorio;
        }
        public IActionResult Index()
        {
           List<FornecedoresModel> fornecedores =_fornecedoresRepositorio.Buscar();
            return View(fornecedores);
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            FornecedoresModel fornecedor =_fornecedoresRepositorio.ListarPorId(id);
            return View(fornecedor);
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(FornecedoresModel fornecedores)
        {

            _fornecedoresRepositorio.Adicionar(fornecedores);
            return RedirectToAction("Index");
        }

        public IActionResult Alterar(FornecedoresModel fornecedores)
        {

            _fornecedoresRepositorio.Atualizar(fornecedores);
            return RedirectToAction("Index");
        }
    }

}