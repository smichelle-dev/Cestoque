﻿using Cestoque.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Controllers
{
    [PaginaUsuarioLogado]
    public class CestasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EditarItensCesta()
        {
            return View();
        }
    }
}
