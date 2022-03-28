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
        public EstoqueRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public EstoqueModel Adicionar(EstoqueModel estoque)
        {
            //grava no banco de dados
            _bancoContext.Estoque.Add(estoque);
            _bancoContext.SaveChanges();
            return estoque;
        }

        public bool Apagar(int id)
        {
            EstoqueModel estoqueDB = ListarPorId(id);

            if (estoqueDB == null) throw new System.Exception("Ocorreu um erro ao tentarmos apagar o produto!");
            _bancoContext.Estoque.Remove(estoqueDB);
            _bancoContext.SaveChanges();
            return true;
        }

        public EstoqueModel Atualizar(EstoqueModel estoque)
        {
            EstoqueModel estoqueDB = ListarPorId(estoque.Id);
            if (estoqueDB == null) throw new System.Exception("Ocorreu um erro ao tentarmos atualizar o produto!");
            estoqueDB.Nome = estoque.Nome;
            estoqueDB.Quantidade = estoque.Quantidade;
            estoqueDB.ValorPorUnidade = estoque.ValorPorUnidade;
            estoqueDB.ValorTotal = estoque.ValorTotal;
            _bancoContext.Estoque.Update(estoqueDB);
            _bancoContext.SaveChanges();
            return estoqueDB;
        }

        public List<EstoqueModel> BuscarTodos()

        {
            //busca os registros
            return _bancoContext.Estoque.ToList();
        }

        public EstoqueModel ListarPorId(int id)
        {
            //lista os registro
            return _bancoContext.Estoque.FirstOrDefault(x => x.Id == id);
        }
    }
}
