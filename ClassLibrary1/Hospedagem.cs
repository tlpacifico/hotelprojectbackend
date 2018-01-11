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

    // Hospedagem
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public partial class Hospedagem
    {
        public int Id { get; set; } // id (Primary key)
        public System.DateTime DtCheckIn { get; set; } // dtCheckIn
        public System.DateTime DtCheckOut { get; set; } // dtCheckOut
        public int IdQuartoAtual { get; set; } // idQuartoAtual
        public int NumHospedes { get; set; } // numHospedes
        public int? IdPreReserva { get; set; } // idPreReserva
        public string IdUserCheckIn { get; set; } // idUserCheckIn (length: 120)
        public string IdUserCheckOut { get; set; } // idUserCheckOut (length: 120)
        public decimal VlDiariaAtual { get; set; } // vlDiariaAtual
        public decimal? VlFechamentoConta { get; set; } // vlFechamentoConta

        // Reverse navigation

        /// <summary>
        /// Child HospedagemConsumoes where [HospedagemConsumo].[idHospedagem] point to this entity (fk_HospedagemConsumo_Hosdagem_idHospdagem)
        /// </summary>
        public System.Collections.Generic.ICollection<HospedagemConsumo> HospedagemConsumoes { get; set; } // HospedagemConsumo.fk_HospedagemConsumo_Hosdagem_idHospdagem
        /// <summary>
        /// Child HospedagemDiarias where [HospedagemDiaria].[idHospedagem] point to this entity (fk_DiariaHospedagem_Hospedagem_idHospedagem)
        /// </summary>
        public System.Collections.Generic.ICollection<HospedagemDiaria> HospedagemDiarias { get; set; } // HospedagemDiaria.fk_DiariaHospedagem_Hospedagem_idHospedagem
        /// <summary>
        /// Child HospedagemHospedes where [HospedagemHospede].[idHospedagem] point to this entity (fk_HospedegemHospede_Hospedagem_idHospedagem)
        /// </summary>
        public System.Collections.Generic.ICollection<HospedagemHospede> HospedagemHospedes { get; set; } // HospedagemHospede.fk_HospedegemHospede_Hospedagem_idHospedagem
        /// <summary>
        /// Child HospedagemPagamentoes where [HospedagemPagamento].[idHospdagem] point to this entity (fk_HospedagemPagamento_Hospedagem_idHospedagem)
        /// </summary>
        public System.Collections.Generic.ICollection<HospedagemPagamento> HospedagemPagamentoes { get; set; } // HospedagemPagamento.fk_HospedagemPagamento_Hospedagem_idHospedagem

        // Foreign keys

        /// <summary>
        /// Parent Quarto pointed by [Hospedagem].([IdQuartoAtual]) (fk_Hospedagem_Quarto_idQuarto)
        /// </summary>
        public Quarto Quarto { get; set; } // fk_Hospedagem_Quarto_idQuarto
        /// <summary>
        /// Parent Reserva pointed by [Hospedagem].([IdPreReserva]) (fk_Hospedagem_PreReserva_idPreReserva)
        /// </summary>
        public Reserva Reserva { get; set; } // fk_Hospedagem_PreReserva_idPreReserva

        public Hospedagem()
        {
            HospedagemConsumoes = new System.Collections.Generic.List<HospedagemConsumo>();
            HospedagemDiarias = new System.Collections.Generic.List<HospedagemDiaria>();
            HospedagemHospedes = new System.Collections.Generic.List<HospedagemHospede>();
            HospedagemPagamentoes = new System.Collections.Generic.List<HospedagemPagamento>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>