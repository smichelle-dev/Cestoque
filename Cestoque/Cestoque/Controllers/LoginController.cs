using Cestoque.Helper;
using Cestoque.Models;
using Cestoque.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;
        public LoginController(IUsuarioRepositorio usuarioRepositorio, 
            ISessao sessao)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
        }


        public IActionResult Index()
        {
            // se o usuario estiver logado vai redirecionar para a home

            if (_sessao.BuscarSessaoUsuario() != null) return RedirectToAction("Index", "home");

            return View();
        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel )
        {

            try
            {
                if (ModelState.IsValid)
                {
                 UsuarioModel usuario =   _usuarioRepositorio.BuscarPorLogin(loginModel.Login);

                    if (usuario != null) 
                    {
                        if(usuario.SenhaValida(loginModel.Senha))
                        {
                            _sessao.CriarSessaoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }

                        TempData["MensagemErro"] = $"Senha inválida, tente novamente.";
                    }
                    TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s), tente novamente.";
                }

                return View("Index");
            }
            catch(Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possivel realizar o seu login. Tente novamente, Detalhe do erro:{erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
