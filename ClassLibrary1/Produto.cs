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

    // Produto
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public partial class Produto
    {
        public int Id { get; set; } // id (Primary key)
        public string Nome { get; set; } // nome (length: 20)
        public int QtdProduto { get; set; } // qtdProduto
        public decimal VlProduto { get; set; } // vlProduto

        // Reverse navigation

        /// <summary>
        /// Child ProdutoMovimentoes where [ProdutoMovimento].[idProduto] point to this entity (fk_ProdutoMovimento_Produto_idProduto)
        /// </summary>
        public System.Collections.Generic.ICollection<ProdutoMovimento> ProdutoMovimentoes { get; set; } // ProdutoMovimento.fk_ProdutoMovimento_Produto_idProduto

        public Produto()
        {
            ProdutoMovimentoes = new System.Collections.Generic.List<ProdutoMovimento>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>