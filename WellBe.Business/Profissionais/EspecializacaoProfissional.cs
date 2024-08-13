namespace WellBe.Business.Profissionais
{
    public class EspecializacaoProfissional
    {
        /// <summary>Código de identificação da especialização do profissional.</summary> 
        public uint IdEspecializacao { get; }

        /// <summary>Tipo da especialização do profissional.</summary> 
        public string Especializacao { get; } = null!;
    }
}