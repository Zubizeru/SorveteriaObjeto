using Sorveteria.Enumeradores;
using Sorveteria.Utilidades;

namespace Sorveteria.Entidade
{
    public class BebidaGelada : ProdutoSorveteria
    {
        public TipoBebida TipoBebida { get; set; }
        public Tamanho Tamanho { get; set; }
        public bool TemAcucar { get; set; }
        public bool TemGelo { get; set; }

        public BebidaGelada(Tamanho tamanho, bool acucar, bool gelo, TipoBebida tipo, StatusProduto status)
        {
            TipoBebida = tipo;
            Tamanho = tamanho;
            TemAcucar = acucar;
            TemGelo = gelo;
            Categoria = CategoriaProduto.Bebida;
            Status = status;

            Preco = Calculos.CalcularPrecoBebida(tamanho, acucar, gelo, tipo, status);
        }
    }
}
