﻿using Cooperchip.ITDeveloper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cooperchip.ITDeveloper.Domain.Models
{
    public class EstadoPaciente : EntityBase
    {
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo '{0}' é obrigatório!")]
        [StringLength(maximumLength: 20, 
            ErrorMessage = "O campo {0} deve ter entre {2} a {1} caracteres!",
            MinimumLength = 5)]
        public string Descricao { get; set; }
    }
}
