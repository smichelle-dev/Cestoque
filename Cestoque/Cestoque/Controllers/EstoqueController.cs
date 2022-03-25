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

        public IActionResult EditarProduto(int id)
        {
            EstoqueModel produto = _estoqueRepositorio.ListarPorId(id);
            return View(produto);
        }

        public IActionResult ApagarProduto(int id)
        {
            EstoqueModel produto = _estoqueRepositorio.ListarPorId(id); //mensagem de confirmacao pra apagar o produto
            return View(produto);
        }


        public IActionResult DeletarProduto(int id) // deleta do bd

        {
            _estoqueRepositorio.DeletarProduto(id);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult CadastrarProduto(EstoqueModel estoque)
        {
            _estoqueRepositorio.Adicionar(estoque);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AlterarProduto(EstoqueModel estoque)
        {
            _estoqueRepositorio.Atualizar(estoque);
            return RedirectToAction("Index");
        }




    }
}
