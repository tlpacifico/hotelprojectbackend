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
    public partial class HospedagemHospede
    {
        public int IdHospedagem { get; set; } // idHospedagem (Primary key)
        public int IdHospede { get; set; } // idHospede (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent Hospedagem pointed by [HospedagemHospede].([IdHospedagem]) (fk_HospedegemHospede_Hospedagem_idHospedagem)
        /// </summary>
        public Hospedagem Hospedagem { get; set; } // fk_HospedegemHospede_Hospedagem_idHospedagem
        /// <summary>
        /// Parent Hospede pointed by [HospedagemHospede].([IdHospede]) (fk_HospedegemHospede_Hospede_idHospede)
        /// </summary>
        public Hospede Hospede { get; set; } // fk_HospedegemHospede_Hospede_idHospede

        public HospedagemHospede()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
