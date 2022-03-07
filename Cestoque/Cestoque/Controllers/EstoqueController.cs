using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Controllers
{
    public class EstoqueController : Controller
    {
        public IActionResult Index()
        {
            return View();
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

    }
}
