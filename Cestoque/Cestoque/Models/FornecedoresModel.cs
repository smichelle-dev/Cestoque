using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Models
{
    public class FornecedoresModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do fornecedor!")]
        public string Fornecedor  { get; set; }
        [Required(ErrorMessage = "Digite o nome do produto!")]
        public string NomeProduto { get; set; }
        [Required(ErrorMessage = "Digite o valor por unidade do produto!")]
        public double ValorUnd { get; set; }
        [Required(ErrorMessage = "Selecione a data!")]
        public DateTime Data  { get; set; }
        [Required(ErrorMessage = "Digite o mês!")]
        public string Mes { get; set; }

    }
}
