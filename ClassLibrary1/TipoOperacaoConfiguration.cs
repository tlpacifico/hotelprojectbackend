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

    // TipoOperacao
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public partial class TipoOperacaoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TipoOperacao>
    {
        public TipoOperacaoConfiguration()
            : this("dbo")
        {
        }

        public TipoOperacaoConfiguration(string schema)
        {
            ToTable("TipoOperacao", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NmTipoOperacao).HasColumnName(@"nmTipoOperacao").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.DsOperacao).HasColumnName(@"dsOperacao").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>