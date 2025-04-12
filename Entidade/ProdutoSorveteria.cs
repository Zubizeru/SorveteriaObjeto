using Sorveteria.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorveteria.Entidade
{
    public abstract class ProdutoSorveteria
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public CategoriaProduto Categoria { get; set; }
        public StatusProduto Status { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Descricao { get; set; }
    }
}
