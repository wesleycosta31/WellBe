using WellBe.Business.Common;

namespace WellBe.Business.Profissionais
{
    public class ProfissionalDto
    {
        /// <summary>Código de identificação do profissional.</summary> 
        public uint IdProfissional { get; set; }

        /// <summary>Nome completo do profissional.</summary>
        public string Nome { get; set; } = null!;

        /// <summary>CPF do profissional.</summary>
        public string CPF { get; set; } = null!;
    }
}