using Sorveteria.Enumeradores;

namespace Sorveteria.Entidade
{
    public class Acai : ProdutoSorveteria
    {
        public TipoAcai TipoAcai { get; set; }
        public Tamanho Tamanho { get; set; }
        public bool TemLeiteCondensado { get; set; }
        public bool TemFruta { get; set; }

        public Acai(TipoAcai tipo, Tamanho tamanho, bool leitecondensado, bool fruta, StatusProduto status)
        {
            TipoAcai = tipo;
            Tamanho = tamanho;
            TemLeiteCondensado = leitecondensado;
            TemFruta = fruta;
            Status = status;
            Categoria = CategoriaProduto.Acai;

            Preco = CalcularPrecoBase();
        }

        public decimal CalcularPrecoBase()
        {
            decimal preco = 0;
            if (Status == StatusProduto.Disponivel)
            {
                switch (TipoAcai)
                {
                    case TipoAcai.Tradicional:
                        preco = 10.00m;
                        break;
                    case TipoAcai.ComBanana:
                        preco = 11.50m;
                        break;
                    case TipoAcai.ZeroAcucar:
                        preco = 12.00m;
                        break;
                }

                switch (Tamanho)
                {
                    case Tamanho.Medio:
                        preco += 2.00m;
                        break;
                    case Tamanho.Grande:
                        preco += 4.00m;
                        break;
                }

                if (TemLeiteCondensado)
                    preco += 1.50m;

                if (TemFruta)
                    preco += 2.00m;

                return preco;
            }
            else return 0;
        }
    }
}
