using Cestoque.Models;
using Cestoque.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Controllers
{
    public class EstoqueController : Controller

    {
        private readonly IEstoqueRepositorio _estoqueRepositorio;
        public EstoqueController(IEstoqueRepositorio estoqueRepositorio)
        {
            _estoqueRepositorio = estoqueRepositorio;
        }
        public IActionResult Index()
        {
          List<EstoqueModel> produtos =  _estoqueRepositorio.BuscarProdutos();
            return View(produtos);
        }

        public IActionResult CadastrarProduto()
        {
            return View();
        }

        public IActionResult EditarProduto()
        {
            return View();
        }

        public IActionResult ApagarProduto()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CadastrarProduto(EstoqueModel estoque)
        {
            _estoqueRepositorio.Adicionar(estoque);
            return RedirectToAction("Index");
        }
        

    }
}
