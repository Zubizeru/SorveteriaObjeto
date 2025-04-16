using Sorveteria.Enumeradores;
using Sorveteria.Utilidades;

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
        public List<Adicionais> Adicionais { get; set; }

        public Sorvete(Sabor sabor, TipoSorvete tipo, Tamanho tamanho, bool possuiCobertura, Cobertura cobertura, bool possuiAdicionais, List<Adicionais> adicionais, StatusProduto status)
        {
            Sabor = sabor;
            Tipo = tipo;
            Tamanho = tamanho;
            PossuiCobertura = possuiCobertura;
            Cobertura = cobertura;
            PossuiAdicionais = possuiAdicionais;
            Adicionais = adicionais;
            Status = status;
            Categoria = CategoriaProduto.Sorvete;

            Preco = Calculos.CalcularPrecoSorvete(sabor, tipo, tamanho, possuiCobertura, cobertura, possuiAdicionais, adicionais, status);
        }
    }
}
