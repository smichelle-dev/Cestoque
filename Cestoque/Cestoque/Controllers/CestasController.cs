﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Controllers
{
    public class CestasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
