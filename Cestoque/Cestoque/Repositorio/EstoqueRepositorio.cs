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
        private readonly BancoContext _Context;
        public EstoqueRepositorio(BancoContext bancoContent){
            this._Context = bancoContent;
          }
        public EstoqueModel Adicionar(EstoqueModel estoque)
        {
            //grava no banco de dados

            _Context.Estoque.Add(estoque);
            _Context.SaveChanges();
            return estoque;
        }

        public EstoqueModel Atualizar(EstoqueModel estoque)  //atualiza no banco
        {
            EstoqueModel produtoDB = ListarPorId(estoque.Id);
            if (produtoDB == null) throw new System.Exception("Ocorreu um erro ao tentar atualizar o produto!");
            produtoDB.NomeProduto = estoque.NomeProduto;
            produtoDB.Quantidade = estoque.Quantidade;
            produtoDB.ValorUnidade = estoque.ValorUnidade;
            produtoDB.ValorTotal = estoque.ValorTotal;
            _Context.Estoque.Update(produtoDB);
            _Context.SaveChanges();
            return produtoDB;

        }

        public List<EstoqueModel> BuscarProdutos()
        {
            return _Context.Estoque.ToList();    //lista produtos

        }

        public EstoqueModel DeletarProduto(int id)
        {
            EstoqueModel produtoDB = ListarPorId(id);

            if (produtoDB == null) throw new System.Exception("Ocorreu um erro ao tentar deletar o produto!");
            _Context.Estoque.Remove(produtoDB);
            _Context.SaveChanges();

            return true;
        }

        public EstoqueModel ListarPorId(int id)   //lista por ID
        {
            return _Context.Estoque.FirstOrDefault(x => x.Id == id);
        }
    }
}
