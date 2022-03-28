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
           List<EstoqueModel> estoque =_estoqueRepositorio.BuscarTodos();
            return View(estoque);
        }

        public IActionResult CadastrarProduto()
        {
            return View();
        }

        public IActionResult EditarProduto(int id)
        {
          EstoqueModel estoque=  _estoqueRepositorio.ListarPorId(id);
            return View(estoque);
        }

        public IActionResult ApagarProdutoConfirmacao(int id)
        {
            EstoqueModel estoque = _estoqueRepositorio.ListarPorId(id);
            return View(estoque);
        }

        public IActionResult ApagarProduto(int id) 
        {
            //apaga do bd
            _estoqueRepositorio.Apagar(id);

            return RedirectToAction("Index");
        }




        [HttpPost]
        public IActionResult CadastrarProduto(EstoqueModel estoque)
        {
          try
            {
                if (ModelState.IsValid)
                {
                    _estoqueRepositorio.Adicionar(estoque);
                    TempData["MensagemSucesso"] = "Produto cadastro com sucesso!";
                    return RedirectToAction("Index");
                }
                return View(estoque);
            }
            catch(System.Exception erro)
            {
                TempData["MensagemErro"] = $"Não conseguimos cadastrar o seu produto.Tente novamente.Detalhe do erro:{erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult AlterarProduto(EstoqueModel estoque)
        {
            if (ModelState.IsValid)
            {
                _estoqueRepositorio.Atualizar(estoque);
                return RedirectToAction("Index");
            }
            return View("EditarProduto",estoque);
        }

    }
}
