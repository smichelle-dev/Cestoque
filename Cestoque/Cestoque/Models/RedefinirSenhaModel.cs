﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cestoque.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Digite o seu login!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o seu e-mail!")]
        public string Email { get; set; }
    }
}
