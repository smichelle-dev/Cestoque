using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Models
{
    public class FornecedoresModel
    {
        public int Id { get; set; }
        public string Fornecedor  { get; set; }
        public string NomeProduto { get; set; }
        public double ValorUnd { get; set; }
        public DateTime  Data  { get; set; }
        public string Mes { get; set; }

    }
}
