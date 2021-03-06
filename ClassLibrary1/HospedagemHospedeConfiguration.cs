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

    // HospedagemHospede
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public partial class HospedagemHospedeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<HospedagemHospede>
    {
        public HospedagemHospedeConfiguration()
            : this("dbo")
        {
        }

        public HospedagemHospedeConfiguration(string schema)
        {
            ToTable("HospedagemHospede", schema);
            HasKey(x => new { x.IdHospedagem, x.IdHospede });

            Property(x => x.IdHospedagem).HasColumnName(@"idHospedagem").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdHospede).HasColumnName(@"idHospede").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.Hospedagem).WithMany(b => b.HospedagemHospedes).HasForeignKey(c => c.IdHospedagem).WillCascadeOnDelete(false); // fk_HospedegemHospede_Hospedagem_idHospedagem
            HasRequired(a => a.Hospede).WithMany(b => b.HospedagemHospedes).HasForeignKey(c => c.IdHospede).WillCascadeOnDelete(false); // fk_HospedegemHospede_Hospede_idHospede
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
