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

    // CaixaMovimento
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public partial class CaixaMovimento
    {
        public int Id { get; set; } // id (Primary key)
        public int? IdHospedagemPagamento { get; set; } // idHospedagemPagamento
        public int? IdProdutoMovimento { get; set; } // idProdutoMovimento
        public int IdTipoOperacao { get; set; } // idTipoOperacao
        public System.DateTime DtOperacao { get; set; } // dtOperacao
        public decimal VlOperacao { get; set; } // vlOperacao
        public string ObsOperacao { get; set; } // obsOperacao (length: 200)

        // Foreign keys

        /// <summary>
        /// Parent HospedagemPagamento pointed by [CaixaMovimento].([IdHospedagemPagamento]) (fk_CaixaMovimento_HospedagemPagamento_idHospedagemPagamento)
        /// </summary>
        public HospedagemPagamento HospedagemPagamento { get; set; } // fk_CaixaMovimento_HospedagemPagamento_idHospedagemPagamento
        /// <summary>
        /// Parent ProdutoMovimento pointed by [CaixaMovimento].([IdProdutoMovimento]) (fk_CaixaMovimento_ProdutoMovimento_idProdutoMovimento)
        /// </summary>
        public ProdutoMovimento ProdutoMovimento { get; set; } // fk_CaixaMovimento_ProdutoMovimento_idProdutoMovimento
        /// <summary>
        /// Parent TipoOperacao pointed by [CaixaMovimento].([IdTipoOperacao]) (fk_CaixaMovimento_TipoOperacao_idTipoOperacao)
        /// </summary>
        public TipoOperacao TipoOperacao { get; set; } // fk_CaixaMovimento_TipoOperacao_idTipoOperacao

        public CaixaMovimento()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
