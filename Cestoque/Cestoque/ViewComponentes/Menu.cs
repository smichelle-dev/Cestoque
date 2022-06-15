﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cestoque.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Cestoque.ViewComponentes
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult>InvokeAsync()
        {
            string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");
            if (string.IsNullOrEmpty(sessaoUsuario)) return null;
            UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);
            return View(usuario);
        }
    }
}
