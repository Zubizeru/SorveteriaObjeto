using Sorveteria.Enumeradores;

namespace Sorveteria.Entidade
{
    public class Sorvete : ProdutoSorveteria
    {
        public string Sabor { get; set; }
        public TipoSorvete Tipo { get; set; }
        public Tamanho Tamanho { get; set; }
        public bool PossuiCobertura { get; set; }
        public Cobertura Cobertura { get; set; }
        public bool PossuiAdicionais { get; set; }

        public Sorvete(string sabor, TipoSorvete tipo, Tamanho tamanho, bool possuicobertura, Cobertura cobertura, bool adicionais)
        {
            Sabor = sabor;
            Tipo = tipo;
            Tamanho = tamanho;
            PossuiCobertura = possuicobertura;
            Cobertura = cobertura;
            PossuiAdicionais = adicionais;

            Preco = CalcularPrecoBase(tipo, tamanho, cobertura);
        }

        private decimal CalcularPrecoBase(TipoSorvete tipo, Tamanho tamanho, Cobertura cobertura)
        {
            decimal preco = 0;

            switch (tipo)
            {
                case TipoSorvete.Casquinha:
                    preco = 4.50m;
                    break;
                case TipoSorvete.Sundae:
                    preco = 9.00m;
                    break;
            }

            switch (tamanho)
            {
                case Tamanho.Medio:
                    preco += 2.00m;
                    break;
                case Tamanho.Grande:
                    preco += 3.00m;
                    break;
            }

            if (PossuiCobertura)
            {
                switch (cobertura)
                {
                    case Cobertura.Chocolate:
                        preco = 0.50m;
                        break;

                    case Cobertura.Morango:
                        preco = 0.48m;
                        break;

                    case Cobertura.Caramelo:
                        preco = 0.46m;
                        break;
                }
            }

            if (PossuiAdicionais)
            {
                preco += 1.00m;
            }

            return preco;
        }
    }
}
