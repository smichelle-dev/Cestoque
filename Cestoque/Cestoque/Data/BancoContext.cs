using Cestoque.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext>options) :base(options)
        {
            
        }

        //aqui vou colocar mais tabelas

        public DbSet<EstoqueModel> Estoque { get; set; }
        public DbSet<FornecedoresModel> Fornecedores { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }


    }
}
