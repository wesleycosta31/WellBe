using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WellBe.Business.Parceiros
{
    public class CategoriaParceiro
    {
        /// <summary>Código de identificação da categoria do parceiro.</summary> 
        public uint IdCategoria { get; }

        /// <summary>Código de identificação da categoria do parceiro.</summary> 
        public string TipoCategoria { get; } = null!;
    }
}