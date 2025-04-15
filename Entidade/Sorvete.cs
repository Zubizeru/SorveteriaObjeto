using Sorveteria.Enumeradores;

namespace Sorveteria.Entidade
{
    public class Sorvete : ProdutoSorveteria
    {
        public Sabor Sabor { get; set; }
        public TipoSorvete Tipo { get; set; }
        public Tamanho Tamanho { get; set; }
        public bool PossuiCobertura { get; set; }
        public Cobertura Cobertura { get; set; }
        public bool PossuiAdicionais { get; set; }

        public Sorvete(Sabor sabor, TipoSorvete tipo, Tamanho tamanho, bool possuiCobertura, Cobertura cobertura, bool adicionais, StatusProduto status)
        {
            Sabor = sabor;
            Tipo = tipo;
            Tamanho = tamanho;
            PossuiCobertura = possuiCobertura;
            Cobertura = cobertura;
            PossuiAdicionais = adicionais;
            Status = status;
            Categoria = CategoriaProduto.Sorvete;

            Preco = CalcularPrecoBase();
        }

        public decimal CalcularPrecoBase()
        {
            decimal preco = 0;
            if (Status == StatusProduto.Disponivel)
            {
                switch (Sabor)
                {
                    case Sabor.Chocolate:
                    case Sabor.Creme:
                    case Sabor.Morango:
                    case Sabor.Coco:
                        preco = 5.00m;
                        break;
                    case Sabor.Flocos:
                    case Sabor.CremeAvelã:
                        preco = 6.00m;
                        break;
                    case Sabor.MentaComChocolate:
                        preco = 6.50m;
                        break;
                    case Sabor.Maracujá:
                        preco = 5.50m;
                        break;
                }

                switch (Tipo)
                {
                    case TipoSorvete.Casquinha:
                        preco += 4.50m;
                        break;
                    case TipoSorvete.Sundae:
                        preco += 9.00m;
                        break;
                }

                switch (Tamanho)
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
                    switch (Cobertura)
                    {
                        case Cobertura.Chocolate:
                            preco += 0.50m;
                            break;
                        case Cobertura.Morango:
                            preco += 0.48m;
                            break;
                        case Cobertura.Caramelo:
                            preco += 0.46m;
                            break;
                    }
                }

                if (PossuiAdicionais)
                {
                    preco += 1.00m;
                }

                return preco;
            }
            else return 0;
        }
    }
}
