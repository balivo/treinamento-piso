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
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Required]
        public decimal Valor { get; set; }
    }
}