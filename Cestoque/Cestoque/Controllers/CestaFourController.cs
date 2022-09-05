using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Controllers
{
    public class CestaFourController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
