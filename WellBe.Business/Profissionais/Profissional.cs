using WellBe.Business.Common;
using WellBe.Business.Parceiros;
using WellBe.Business.Profissionais.Agenda;

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
        public Endereco Endereco { get; }

        /// <summary>Lista de especializações do profissional.</summary>
        public IEnumerable<EspecializacaoProfissional> Especializacoes { get; }

        /// <summary>Lista de especializações do profissional.</summary>
        public IEnumerable<EmpresaParceiro> ParceiroProfissional { get; }

        /// <summary>Agenda do profissional.</summary>
        public AgendaProfissional Agenda { get; }

        // Gerar construtores para as classes

        // Trabalhar no desenvolvimento da agenda do profissional.
    }
}