using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Models
{
    public class EstoqueModel
    {
       public int Id { get; set; }
        [Required(ErrorMessage ="Digite o nome do produto!")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Digite a quantidade do produto!")]
        public int Quantidade { get; set; }
        [Required(ErrorMessage ="Digite o valor por unidade do produto!")]
        public double ValorPorUnidade { get; set; }
        public double ValorTotal { get; set; }

        //criar outra variavel aqui para somar quantidade+valorpor unidade 

    }
}
