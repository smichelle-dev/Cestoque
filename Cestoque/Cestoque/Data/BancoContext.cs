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
        public DbSet<CestaOneModel> CestaOne { get; set; }
        public DbSet<CestaTwoModel> CestaTwo { get; set; }
        public DbSet<CestaThreeModel> CestaThree { get; set; }
        public DbSet<CestaFourModel> CestaFour { get; set; }
        public DbSet<CestasModel> Cestas { get; set; }




    }
}
