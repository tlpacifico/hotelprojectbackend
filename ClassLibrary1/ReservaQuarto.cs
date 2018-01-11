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

    // ReservaQuarto
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public partial class ReservaQuarto
    {
        public int Id { get; set; } // id (Primary key)
        public int IdReserva { get; set; } // idReserva
        public int IdQuarto { get; set; } // idQuarto
        public int QtdPessoa { get; set; } // qtdPessoa
        public decimal Valor { get; set; } // valor

        // Reverse navigation

        /// <summary>
        /// Child ReservaAgendamentoes where [ReservaAgendamento].[idReservaQuarto] point to this entity (fk_Alocacao_PreReservaQuarto_idPreReservaQuarto)
        /// </summary>
        public System.Collections.Generic.ICollection<ReservaAgendamento> ReservaAgendamentoes { get; set; } // ReservaAgendamento.fk_Alocacao_PreReservaQuarto_idPreReservaQuarto

        // Foreign keys

        /// <summary>
        /// Parent Quarto pointed by [ReservaQuarto].([Id]) (fk_PreReservaQuarto_Quarto_idQuarto)
        /// </summary>
        public Quarto Quarto { get; set; } // fk_PreReservaQuarto_Quarto_idQuarto
        /// <summary>
        /// Parent Reserva pointed by [ReservaQuarto].([IdReserva]) (fk_PreReservaQuarto_PreReserva_idReserva)
        /// </summary>
        public Reserva Reserva { get; set; } // fk_PreReservaQuarto_PreReserva_idReserva

        public ReservaQuarto()
        {
            ReservaAgendamentoes = new System.Collections.Generic.List<ReservaAgendamento>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
