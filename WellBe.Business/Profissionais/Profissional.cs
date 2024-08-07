using WellBe.Business.Common;

namespace WellBe.Business.Profissionais
{
    public class Profissional
    {
        /// <summary>Código de identificação do profissional.</summary> 
        public uint IdProfissional { get; }

        /// <summary>Nome completo do profissional.</summary>
        public string Nome { get; } = null!;

        /// <summary>CPF do profissional.</summary>
        public string CPF { get; } = null!;

        /// <summary>CNPJ da empresa do profissional.</summary>
        public string? CNPJ { get; }

        /// <summary>Data de nascimento do profissional.</summary>
        public DateTime DataNascimento { get; }

        /// <summary>Endereço do profissional.</summary>
        public Endereco? Endereco { get; } = null!;

        // Trabalhar no desenvolvimento da agenda do profissional.
    }
}