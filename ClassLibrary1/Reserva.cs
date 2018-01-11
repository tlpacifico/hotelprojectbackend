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

    // Reserva
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public partial class Reserva
    {
        public int Id { get; set; } // id (Primary key)
        public string NmReserva { get; set; } // nmReserva (length: 120)
        public System.DateTime DtCheckIn { get; set; } // dtCheckIn
        public System.DateTime DtCheckOut { get; set; } // dtCheckOut
        public int IdTipoReserva { get; set; } // idTipoReserva
        public string Email { get; set; } // email (length: 40)
        public string DsCelular { get; set; } // dsCelular (length: 11)
        public bool? FlZap { get; set; } // flZap
        public string DsObsGeral { get; set; } // dsObsGeral

        // Reverse navigation

        /// <summary>
        /// Child Hospedagems where [Hospedagem].[idPreReserva] point to this entity (fk_Hospedagem_PreReserva_idPreReserva)
        /// </summary>
        public System.Collections.Generic.ICollection<Hospedagem> Hospedagems { get; set; } // Hospedagem.fk_Hospedagem_PreReserva_idPreReserva
        /// <summary>
        /// Child ReservaPagamentoes where [ReservaPagamento].[idReserva] point to this entity (fl_ReservaPagamento_Reserva_idReserva)
        /// </summary>
        public System.Collections.Generic.ICollection<ReservaPagamento> ReservaPagamentoes { get; set; } // ReservaPagamento.fl_ReservaPagamento_Reserva_idReserva
        /// <summary>
        /// Child ReservaQuartoes where [ReservaQuarto].[idReserva] point to this entity (fk_PreReservaQuarto_PreReserva_idReserva)
        /// </summary>
        public System.Collections.Generic.ICollection<ReservaQuarto> ReservaQuartoes { get; set; } // ReservaQuarto.fk_PreReservaQuarto_PreReserva_idReserva

        public Reserva()
        {
            Hospedagems = new System.Collections.Generic.List<Hospedagem>();
            ReservaPagamentoes = new System.Collections.Generic.List<ReservaPagamento>();
            ReservaQuartoes = new System.Collections.Generic.List<ReservaQuarto>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>