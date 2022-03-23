using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Models
{
    public class EstoqueModel
    {
        public int Id {get;set;}
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public float ValorUnidade { get; set; }
        public float ValorTotal { get; set; }

    }
}
