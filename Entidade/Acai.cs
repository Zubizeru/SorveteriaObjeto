using Sorveteria.Enumeradores;
using Sorveteria.Utilidades;

namespace Sorveteria.Entidade
{
    public class Acai : ProdutoSorveteria
    {
        public TipoAcai TipoAcai { get; set; }
        public Tamanho Tamanho { get; set; }
        public bool PossuiCobertura { get; set; }
        public Cobertura Cobertura { get; set; }
        public bool PossuiAdicionais { get; set; }
        public List<Adicionais> Adicionais { get; set; }

        public Acai(TipoAcai tipo, Tamanho tamanho, bool possuiCobertura, Cobertura cobertura, bool possuiadicionais, List<Adicionais> adicionais, StatusProduto status)
        {
            TipoAcai = tipo;
            Tamanho = tamanho;
            PossuiCobertura = possuiCobertura;
            Cobertura = cobertura;
            PossuiAdicionais = possuiadicionais;
            Adicionais = adicionais;
            Status = status;

            Preco = Calculos.CalcularPrecoAcai(tipo, tamanho, possuiCobertura, cobertura, possuiadicionais, adicionais, status);
        }
    }
}
