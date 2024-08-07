using WellBe.Business.Common;

namespace WellBe.Business.Parceiros
{
    public class EmpresaParceiro
    {
        /// <summary>Código de identificação da empresa parceira.</summary> 
        public uint IdEmpresaParceiro { get; }

        /// <summary>Razao social da empresa parceira.</summary>
        public string RazaoSocial { get; } = null!;

        /// <summary>Nome do estabelecimento parceira.</summary>
        public string NomeEstabelecimento { get; } = null!;

        /// <summary>CNPJ da empresa parceira.</summary>
        public int Telefone { get; }

        /// <summary>Endereço do parceiro.</summary>
        public Endereco? Endereco { get; } = null!;

        /// <summary>Categoria do negócio do parceiro.</summary> 
        public IEnumerable<CategoriaParceiro>? Categoria { get; }
    }
}