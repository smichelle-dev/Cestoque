using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Models
{
    public class CestaFourModel
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public DateTime DataDeCadastro { get; set; }
    }
}
