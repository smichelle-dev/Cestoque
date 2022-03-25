using Cestoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Repositorio
{
    public interface IEstoqueRepositorio
    {
        EstoqueModel ListarPorId(int id);  //pega o  Id pra listar 
        List<EstoqueModel> BuscarProdutos();
        EstoqueModel Adicionar(EstoqueModel Estoque);  // grava no banco de dados
        EstoqueModel Atualizar(EstoqueModel Estoque); //atualiza no banco

        EstoqueModel DeletarProduto(int id);
    }
}
