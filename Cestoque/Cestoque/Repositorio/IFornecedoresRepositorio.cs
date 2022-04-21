using Cestoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Repositorio
{
    public interface IFornecedoresRepositorio
    {

        List<FornecedoresModel> Buscar();
        FornecedoresModel Adicionar(FornecedoresModel fornecedor);
        FornecedoresModel ListarPorId(int id);
        FornecedoresModel Atualizar(FornecedoresModel fornecedor);


    }
}
