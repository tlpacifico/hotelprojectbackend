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
    public partial class TipoQuartoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TipoQuarto>
    {
        public TipoQuartoConfiguration()
            : this("dbo")
        {
        }

        public TipoQuartoConfiguration(string schema)
        {
            ToTable("TipoQuarto", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DsQuarto).HasColumnName(@"dsQuarto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>