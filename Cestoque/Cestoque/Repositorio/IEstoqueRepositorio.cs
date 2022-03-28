using Cestoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Repositorio
{
    public interface IEstoqueRepositorio
    {
        EstoqueModel ListarPorId(int id);
        List<EstoqueModel> BuscarTodos();

        EstoqueModel Atualizar(EstoqueModel estoque);
        EstoqueModel Adicionar(EstoqueModel estoque);

        bool Apagar(int id);
    }
}
