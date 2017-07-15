using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestaoComercial.Web.Models
{
    [Table("Produto")]
    public partial class Produto
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nome do produto")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Preço de venda")]
        public decimal Valor { get; set; }
    }
}