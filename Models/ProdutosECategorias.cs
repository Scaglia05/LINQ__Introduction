using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    public class Produto {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public decimal Valor { get; set; }
    }

    public class Categoria {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
    }

    class ProdutoDto { 
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Status { get; set; }
    }
}
