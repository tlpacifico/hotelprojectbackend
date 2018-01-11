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

    // TipoQuarto
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public partial class TipoQuarto
    {
        public int Id { get; set; } // id (Primary key)
        public string DsQuarto { get; set; } // dsQuarto (length: 30)

        // Reverse navigation

        /// <summary>
        /// Child Quartos where [Quarto].[idTipoQuarto] point to this entity (fk_Quarto_TipoQuarto_idTipoQuarto)
        /// </summary>
        public System.Collections.Generic.ICollection<Quarto> Quartos { get; set; } // Quarto.fk_Quarto_TipoQuarto_idTipoQuarto

        public TipoQuarto()
        {
            Quartos = new System.Collections.Generic.List<Quarto>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>