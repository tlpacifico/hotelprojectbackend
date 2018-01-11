// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace ClassLibrary1
{

    // HospedagemPagamento
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public partial class HospedagemPagamento
    {
        public int Id { get; set; } // id (Primary key)
        public int IdHospdagem { get; set; } // idHospdagem
        public System.DateTime DtPagamento { get; set; } // dtPagamento
        public int QtdDiaria { get; set; } // qtdDiaria
        public decimal VlTotalDiaria { get; set; } // vlTotalDiaria
        public int IdTipoPagamento { get; set; } // idTipoPagamento
        public string ObsPagamento { get; set; } // obsPagamento (length: 200)
        public decimal? VlTotalConsumo { get; set; } // vlTotalConsumo
        public System.DateTime DtInicioDiaria { get; set; } // dtInicioDiaria
        public System.DateTime DtFimDiaria { get; set; } // dtFimDiaria

        // Reverse navigation

        /// <summary>
        /// Child CaixaMovimentoes where [CaixaMovimento].[idHospedagemPagamento] point to this entity (fk_CaixaMovimento_HospedagemPagamento_idHospedagemPagamento)
        /// </summary>
        public System.Collections.Generic.ICollection<CaixaMovimento> CaixaMovimentoes { get; set; } // CaixaMovimento.fk_CaixaMovimento_HospedagemPagamento_idHospedagemPagamento

        // Foreign keys

        /// <summary>
        /// Parent Hospedagem pointed by [HospedagemPagamento].([IdHospdagem]) (fk_HospedagemPagamento_Hospedagem_idHospedagem)
        /// </summary>
        public Hospedagem Hospedagem { get; set; } // fk_HospedagemPagamento_Hospedagem_idHospedagem
        /// <summary>
        /// Parent TipoPagamento pointed by [HospedagemPagamento].([IdTipoPagamento]) (fk_HospedagemPagamento_TipoPagamento_idTipoPagamento)
        /// </summary>
        public TipoPagamento TipoPagamento { get; set; } // fk_HospedagemPagamento_TipoPagamento_idTipoPagamento

        public HospedagemPagamento()
        {
            CaixaMovimentoes = new System.Collections.Generic.List<CaixaMovimento>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
