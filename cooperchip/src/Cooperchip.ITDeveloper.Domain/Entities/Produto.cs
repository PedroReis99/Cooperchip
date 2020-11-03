using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cooperchip.ITDeveloper.Domain.Entities
{
    public class Produto
    {
        public Produto()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        [Display(Name = "Id do Produto")]
        public Guid Id { get; set; }
        
        [Display(Name = "Nome do Produto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(80, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres!", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [Range(0, 4000, ErrorMessage = "O campo {0} deve valer entre {2} e {1}")]
        public decimal Valor { get; set; }


        public int Estoque { get; set; } = 0;

        [Display(Name = "Data de Validade!", Description = "Selecione uma data futura para a validade")]
        [DataType(DataType.Date, ErrorMessage = "Data invalida!"), 
            DisplayFormat(DataFormatString = "0:dd/MM/yyyy HH:mm")]
        public DateTime Validade { get; set; }
        public bool TemEmEstoque { get; set; } = true;
    }
}
