using Cestoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorLogin(string login);
        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> BuscarTodos();

        UsuarioModel Atualizar(UsuarioModel usuario);
        UsuarioModel Adicionar(UsuarioModel usuario);

        bool Apagar(int id);
    }
}
