using Sorveteria.Enumeradores;

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

            Preco = CalcularPrecoBase();
        }

        public decimal CalcularPrecoBase()
        {
            if (Status == StatusProduto.Disponivel)
            {
                decimal preco = 0;

                switch (TipoBebida)
                {
                    case TipoBebida.Suco:
                        preco = 11.00m;
                        break;
                    case TipoBebida.Refrigerante:
                        preco = 6.00m;
                        break;
                    case TipoBebida.Agua:
                        preco = 5.00m;
                        break;
                }

                switch (Tamanho)
                {
                    case Tamanho.Medio:
                        preco += 3.00m;
                        break;
                    case Tamanho.Grande:
                        preco += 6.00m;
                        break;
                }

                if (TemGelo)
                    preco += 1.00m;

                if (TemAcucar)
                    preco += 1.00m;

                return preco;
            }
            else return 0;
        }
    }
}
