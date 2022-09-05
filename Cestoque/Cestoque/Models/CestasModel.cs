using Cestoque.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Models
{
    public class CestasModel
    {
        public int Id { get; set; }
        public CestasEnum Cesta { get; set; }
        public int QuantidadeVendidas { get; set; }
        public DateTime DataDeCadastro { get; set; }
    }
}
