
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
            List<FornecedoresModel> fornecedores = _fornecedoresRepositorio.Buscar();
            return View(fornecedores);
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            FornecedoresModel fornecedor = _fornecedoresRepositorio.ListarPorId(id);
            return View(fornecedor);
        }
        public IActionResult ApagarConfirmacao(int id)

        {
            FornecedoresModel fornecedor = _fornecedoresRepositorio.ListarPorId(id);
            return View(fornecedor);
        }
        public IActionResult Apagar(int id)

        {
            try
            {
                bool apagado= _fornecedoresRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Fornecedor apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Não conseguimos apagar o fornecedor.Tente novamente.Detalhe do erro";

                }
                return RedirectToAction("Index");
                
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Não conseguimos alterar o fornecedor.Tente novamente.Detalhe do erro:{erro.Message}";
                return RedirectToAction("Index");
            }

        
        }

        [HttpPost]
        public IActionResult Criar(FornecedoresModel fornecedores)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    _fornecedoresRepositorio.Adicionar(fornecedores);
                    TempData["MensagemSucesso"] = "Fornecedor cadastro com sucesso!";
                    return RedirectToAction("Index");

                }
                return View(fornecedores);
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Não conseguimos cadastrar o fornecedor.Tente novamente.Detalhe do erro:{erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(FornecedoresModel fornecedores)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    _fornecedoresRepositorio.Atualizar(fornecedores);
                    TempData["MensagemSucesso"] = "Fornecedor alterado com sucesso!";
                    return RedirectToAction("Index");

                }
                return View("Editar", fornecedores);
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Não conseguimos alterar o fornecedor.Tente novamente.Detalhe do erro:{erro.Message}";
                return RedirectToAction("Index");
            }
            

        }

    }
}