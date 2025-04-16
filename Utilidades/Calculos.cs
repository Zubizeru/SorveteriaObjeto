using Sorveteria.Enumeradores;

namespace Sorveteria.Utilidades
{
    public static class Calculos
    {
        public static decimal CalcularPrecoAcai( TipoAcai tipo, Tamanho tamanho, bool possuiCobertura, Cobertura cobertura, bool possuiAdicionais, List<Adicionais> adicionais, StatusProduto status)
        {
            if (status != StatusProduto.Disponivel)
                return 0;

            decimal preco = 0;

            switch (tipo)
            {
                case TipoAcai.Tradicional:
                    preco += 10.00m;
                    break;
                case TipoAcai.ComBanana:
                    preco += 11.50m;
                    break;
                case TipoAcai.ZeroAcucar:
                    preco += 12.00m;
                    break;
            }

            switch (tamanho)
            {
                case Tamanho.Medio:
                    preco += 2.00m;
                    break;
                case Tamanho.Grande:
                    preco += 4.00m;
                    break;
            }

            if (possuiCobertura)
            {
                switch (cobertura)
                {
                    case Cobertura.Chocolate:
                        preco += 2.00m;
                        break;
                    case Cobertura.Morango:
                        preco += 2.50m;
                        break;
                    case Cobertura.Caramelo:
                        preco += 2.20m;
                        break;
                }
            }

            if (possuiAdicionais && adicionais != null)
            {
                preco += adicionais.Count * 1.50m;
            }

            return preco;
        }

        public static decimal CalcularPrecoBebida(Tamanho tamanho, bool acucar, bool gelo, TipoBebida tipo, StatusProduto status)
        {
            if (status == StatusProduto.Disponivel)
            {
                decimal preco = 0;

                switch (tipo)
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

                switch (tamanho)
                {
                    case Tamanho.Medio:
                        preco += 3.00m;
                        break;
                    case Tamanho.Grande:
                        preco += 6.00m;
                        break;
                }

                if (gelo)
                    preco += 1.00m;

                if (acucar)
                    preco += 1.00m;

                return preco;
            }
            else return 0;
        }

        public static decimal CalcularPrecoSorvete( Sabor sabor, TipoSorvete tipo, Tamanho tamanho, bool possuiCobertura, Cobertura cobertura, bool possuiAdicionais, List<Adicionais> adicionais, StatusProduto status)
        {
            if (status != StatusProduto.Disponivel)
                return 0;

            decimal preco = 0;

            switch (sabor)
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
                default:
                    break;
            }

            switch (tipo)
            {
                case TipoSorvete.Casquinha:
                    preco += 4.50m;
                    break;
                case TipoSorvete.Sundae:
                    preco += 9.00m;
                    break;
                default:
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
                default:
                    break;
            }

            if (possuiCobertura)
            {
                switch (cobertura)
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
                    default:
                        break;
                }
            }

            if (possuiAdicionais && adicionais != null)
            {
                preco += adicionais.Count * 1.00m;
            }

            return preco;
        }

    }
}