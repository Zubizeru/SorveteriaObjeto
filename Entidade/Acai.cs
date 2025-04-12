using Sorveteria.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorveteria.Entidade
{
    public class Acai : ProdutoSorveteria
    {
        public Tamanho Tamanho { get; set; }
        public bool TemLeiteCondensado { get; set; }
        public bool TemFruta { get; set; }
        public TipoAcai TipoAcai { get; set; }

        public Acai(TipoAcai tipo, Tamanho tamanho, bool leitecondensado, bool fruta)
        {
            TipoAcai = tipo;
            Tamanho = tamanho;
            Categoria = CategoriaProduto.Acai;
            Status = StatusProduto.Disponivel;
            TemLeiteCondensado = leitecondensado;
            TemFruta = fruta;

            Preco = CalcularPrecoBase(tipo, tamanho); // agora considera extras
        }

        private decimal CalcularPrecoBase(TipoAcai tipo, Tamanho tamanho)
        {
            decimal preco = 0;

            // Define o preço base pelo tipo
            switch (tipo)
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

            // Acrescenta valor conforme o tamanho
            switch (tamanho)
            {
                case Tamanho.Medio:
                    preco += 2.00m;
                    break;
                case Tamanho.Grande:
                    preco += 4.00m;
                    break;
            }

            // Extras
            if (TemLeiteCondensado)
                preco += 1.50m;

            if (TemFruta)
                preco += 2.00m;

            return preco;
        }
    }
}
