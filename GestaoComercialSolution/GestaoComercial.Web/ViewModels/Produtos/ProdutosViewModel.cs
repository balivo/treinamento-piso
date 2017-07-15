using GestaoComercial.Web.Models;
using System.Collections.Generic;

namespace GestaoComercial.Web.ViewModels.Produtos
{
    public sealed class ProdutosViewModel
    {
        public string Titulo { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}