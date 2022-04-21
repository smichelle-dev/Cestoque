using Cestoque.Data;
using Cestoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Repositorio
{
    public class FornecedoresRepositorio : IFornecedoresRepositorio
    {
        private readonly BancoContext _Context;
        public FornecedoresRepositorio(BancoContext bancoContext)
        {
            this._Context = bancoContext;
        }
        public FornecedoresModel Adicionar(FornecedoresModel fornecedor)
        {
            _Context.Fornecedores.Add(fornecedor);
            _Context.SaveChanges();
            return fornecedor;
        }

        public FornecedoresModel Atualizar(FornecedoresModel fornecedor)
        {
            FornecedoresModel fornecedorDb = ListarPorId(fornecedor.Id);
            if (fornecedorDb == null) throw new System.Exception("Houve um erro ao tentarmos atualizar o fornecedor!");
            fornecedorDb.Fornecedor = fornecedor.Fornecedor;
            fornecedorDb.NomeProduto = fornecedor.NomeProduto;
            fornecedorDb.ValorUnd = fornecedor.ValorUnd;
            fornecedorDb.Data = fornecedor.Data;
            fornecedorDb.Mes = fornecedor.Mes;
            _Context.Fornecedores.Update(fornecedorDb);
            _Context.SaveChanges();
            return fornecedorDb;
        }
        public List<FornecedoresModel> Buscar()
        {
            return _Context.Fornecedores.ToList();
        }

        public FornecedoresModel ListarPorId(int id)
        {
            return _Context.Fornecedores.FirstOrDefault(x=>x.Id ==id);
        }
    }
}
