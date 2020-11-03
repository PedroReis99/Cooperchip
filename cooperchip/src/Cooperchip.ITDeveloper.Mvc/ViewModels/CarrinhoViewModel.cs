using Cooperchip.ITDeveloper.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cooperchip.ITDeveloper.Mvc.ViewModels
{
    public class CarrinhoViewModel
    {
        public IList<Produto> Produtos { get; set; }

        [Required]
        [Range(100, 400, ErrorMessage = "O campo {0} deve estar entre {2} e {1}")]
        public decimal TotalCarrinho { get; set; }

        [Required]
        [StringLength(80, ErrorMessage = "O campo deve estar entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Mensagem { get; set; }
    }
}
