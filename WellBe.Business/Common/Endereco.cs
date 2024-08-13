using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WellBe.Business.Common
{
    public class Endereco
    {
        /// <summary> Código de identificação do endereço.</summary> 
        public int IdEndereco { get; }

        /// <summary> CEP do endereço.</summary> 
        public int CEP { get; }

        /// <summary> UF do endereço.</summary> 
        public string Estado { get; } = null!;

        /// <summary> Cidade do endereço.</summary> 
        public string Cidade { get; } = null!;

        /// <summary> Bairro do endereço.</summary> 
        public string Bairro { get; } = null!;

        /// <summary> Rua do endereço.</summary> 
        public string Rua { get; } = null!;

        /// <summary> Complemento do endereço.</summary> 
        public string? Complemento { get; }

        /// <summary> Numero do endereço.</summary> 
        public int Numero { get; }
    }
}