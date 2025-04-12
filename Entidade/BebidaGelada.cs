using Sorveteria.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorveteria.Entidade
{
    public class BebidaGelada : ProdutoSorveteria
    {
        public Tamanho Tamanho { get; set; }
        public bool ContemAcucar { get; set; }
        public bool TemGelo { get; set; }
        public TipoBebida TipoBebida { get; set; }

        public BebidaGelada(Tamanho tamanho, bool acucar, bool gelo, TipoBebida tipo) 
        {
            Tamanho = tamanho;
            ContemAcucar = acucar;
            TemGelo = gelo;
            TipoBebida = tipo;
            Categoria = CategoriaProduto.Bebida;
            Status = StatusProduto.Disponivel;

            Preco = CalcularPrecoBase(tipo, tamanho);
        }

        private decimal CalcularPrecoBase(TipoBebida tipo, Tamanho tamanho)
        {
            decimal preco = 0;

            // Define o preço base pelo tipo
            switch (tipo)
            {
                case TipoBebida.Suco:
                    preco = 11.00m;
                    break;
                case TipoBebida.Refrigerante:
                    preco = 9.00m;
                    break;
                case TipoBebida.Agua:
                    preco = 5.00m;
                    break;
            }

            // Acrescenta valor conforme o tamanho
            switch (tamanho)
            {
                case Tamanho.Medio:
                    preco += 2.00m;
                    break;
                case Tamanho.Grande:
                    preco += 3.00m;
                    break;
            }

            // Extras
            if (TemGelo)
                preco += 1.00m;

            if (ContemAcucar)
                preco += 1.00m;

            return preco;
        }
    }
}
