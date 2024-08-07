using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellBe.Business.Common;

namespace WellBe.Business.Parceiros
{
    public class ResponsavelParceiro
    {
        /// <summary>Código de identificação do parceiro.</summary> 
        public uint IdResponsavelParceiro { get; }

        /// <summary>Nome completo do parceiro.</summary>
        public string Nome { get; } = null!;

        /// <summary>CPF do responsável.</summary>
        public string CPF { get; } = null!;

        /// <summary>CNPJ da empresa parceira.</summary>
        public string CNPJ { get; } = null!;

        /// <summary>Data de nascimento do parceiro.</summary>
        public DateTime DataNascimento { get; }

        /// <summary>Endereço do parceiro.</summary>
        public Endereco? Endereco { get; } = null!;
    }
}