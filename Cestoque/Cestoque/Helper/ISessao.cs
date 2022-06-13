using Cestoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Helper
{
    interface ISessao
    {

        void CriarSessaoUsuario(UsuarioModel usuario);
        void RemoverSessaoUsuario();

        UsuarioModel BuscarSessaoUsuario();
    }
}
