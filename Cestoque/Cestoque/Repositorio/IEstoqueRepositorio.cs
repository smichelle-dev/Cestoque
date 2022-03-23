using Cestoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Repositorio
{
    public interface IEstoqueRepositorio
    {
        List<EstoqueModel> BuscarProdutos();
        EstoqueModel Adicionar(EstoqueModel Estoque);  // grava no banco de dados
    }
}
