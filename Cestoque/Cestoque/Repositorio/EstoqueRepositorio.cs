using Cestoque.Data;
using Cestoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Repositorio
{
    public class EstoqueRepositorio : IEstoqueRepositorio
    {
        private readonly BancoContext _bancoContext;
        public EstoqueRepositorio(BancoContext bancoContext){
            _bancoContext = bancoContext;
          }
        public EstoqueModel Adicionar(EstoqueModel Estoque)
        {
            //grava no banco de dados

            _bancoContext.Estoque.Add(Estoque);
            _bancoContext.SaveChanges();
            return Estoque;
        }

        public List<EstoqueModel> BuscarProdutos()
        {
            return _bancoContext.Estoque.ToList();    //lista produtos

        }
    }
}
