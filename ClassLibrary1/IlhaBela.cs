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

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public partial class IlhaBela : System.Data.Entity.DbContext, IIlhaBela
    {
        public System.Data.Entity.DbSet<CaixaMovimento> CaixaMovimentoes { get; set; } // CaixaMovimento
        public System.Data.Entity.DbSet<Cama> Camas { get; set; } // Cama
        public System.Data.Entity.DbSet<Empresa> Empresas { get; set; } // Empresa
        public System.Data.Entity.DbSet<Hospedagem> Hospedagems { get; set; } // Hospedagem
        public System.Data.Entity.DbSet<HospedagemConsumo> HospedagemConsumoes { get; set; } // HospedagemConsumo
        public System.Data.Entity.DbSet<HospedagemDiaria> HospedagemDiarias { get; set; } // HospedagemDiaria
        public System.Data.Entity.DbSet<HospedagemHospede> HospedagemHospedes { get; set; } // HospedagemHospede
        public System.Data.Entity.DbSet<HospedagemPagamento> HospedagemPagamentoes { get; set; } // HospedagemPagamento
        public System.Data.Entity.DbSet<Hospede> Hospedes { get; set; } // Hospede
        public System.Data.Entity.DbSet<Produto> Produtoes { get; set; } // Produto
        public System.Data.Entity.DbSet<ProdutoMovimento> ProdutoMovimentoes { get; set; } // ProdutoMovimento
        public System.Data.Entity.DbSet<Quarto> Quartos { get; set; } // Quarto
        public System.Data.Entity.DbSet<QuartoCama> QuartoCamas { get; set; } // QuartoCama
        public System.Data.Entity.DbSet<Reserva> Reservas { get; set; } // Reserva
        public System.Data.Entity.DbSet<ReservaAgendamento> ReservaAgendamentoes { get; set; } // ReservaAgendamento
        public System.Data.Entity.DbSet<ReservaPagamento> ReservaPagamentoes { get; set; } // ReservaPagamento
        public System.Data.Entity.DbSet<ReservaQuarto> ReservaQuartoes { get; set; } // ReservaQuarto
        public System.Data.Entity.DbSet<TipoOperacao> TipoOperacaos { get; set; } // TipoOperacao
        public System.Data.Entity.DbSet<TipoPagamento> TipoPagamentoes { get; set; } // TipoPagamento
        public System.Data.Entity.DbSet<TipoQuarto> TipoQuartoes { get; set; } // TipoQuarto

        static IlhaBela()
        {
            System.Data.Entity.Database.SetInitializer<IlhaBela>(null);
            IlhaBelaStaticPartial(); // Create the following method in your partial class: private static void IlhaBelaStaticPartial() { }
        }

        public IlhaBela()
            : base("Name=IlhaBelaCs")
        {
            InitializePartial();
        }

        public IlhaBela(string connectionString)
            : base(connectionString)
        {
            InitializePartial();
        }

        public IlhaBela(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
            InitializePartial();
        }

        public IlhaBela(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            InitializePartial();
        }

        public IlhaBela(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
            InitializePartial();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CaixaMovimentoConfiguration());
            modelBuilder.Configurations.Add(new CamaConfiguration());
            modelBuilder.Configurations.Add(new EmpresaConfiguration());
            modelBuilder.Configurations.Add(new HospedagemConfiguration());
            modelBuilder.Configurations.Add(new HospedagemConsumoConfiguration());
            modelBuilder.Configurations.Add(new HospedagemDiariaConfiguration());
            modelBuilder.Configurations.Add(new HospedagemHospedeConfiguration());
            modelBuilder.Configurations.Add(new HospedagemPagamentoConfiguration());
            modelBuilder.Configurations.Add(new HospedeConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new ProdutoMovimentoConfiguration());
            modelBuilder.Configurations.Add(new QuartoConfiguration());
            modelBuilder.Configurations.Add(new QuartoCamaConfiguration());
            modelBuilder.Configurations.Add(new ReservaConfiguration());
            modelBuilder.Configurations.Add(new ReservaAgendamentoConfiguration());
            modelBuilder.Configurations.Add(new ReservaPagamentoConfiguration());
            modelBuilder.Configurations.Add(new ReservaQuartoConfiguration());
            modelBuilder.Configurations.Add(new TipoOperacaoConfiguration());
            modelBuilder.Configurations.Add(new TipoPagamentoConfiguration());
            modelBuilder.Configurations.Add(new TipoQuartoConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CaixaMovimentoConfiguration(schema));
            modelBuilder.Configurations.Add(new CamaConfiguration(schema));
            modelBuilder.Configurations.Add(new EmpresaConfiguration(schema));
            modelBuilder.Configurations.Add(new HospedagemConfiguration(schema));
            modelBuilder.Configurations.Add(new HospedagemConsumoConfiguration(schema));
            modelBuilder.Configurations.Add(new HospedagemDiariaConfiguration(schema));
            modelBuilder.Configurations.Add(new HospedagemHospedeConfiguration(schema));
            modelBuilder.Configurations.Add(new HospedagemPagamentoConfiguration(schema));
            modelBuilder.Configurations.Add(new HospedeConfiguration(schema));
            modelBuilder.Configurations.Add(new ProdutoConfiguration(schema));
            modelBuilder.Configurations.Add(new ProdutoMovimentoConfiguration(schema));
            modelBuilder.Configurations.Add(new QuartoConfiguration(schema));
            modelBuilder.Configurations.Add(new QuartoCamaConfiguration(schema));
            modelBuilder.Configurations.Add(new ReservaConfiguration(schema));
            modelBuilder.Configurations.Add(new ReservaAgendamentoConfiguration(schema));
            modelBuilder.Configurations.Add(new ReservaPagamentoConfiguration(schema));
            modelBuilder.Configurations.Add(new ReservaQuartoConfiguration(schema));
            modelBuilder.Configurations.Add(new TipoOperacaoConfiguration(schema));
            modelBuilder.Configurations.Add(new TipoPagamentoConfiguration(schema));
            modelBuilder.Configurations.Add(new TipoQuartoConfiguration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(System.Data.Entity.DbModelBuilder modelBuilder);
    }
}
// </auto-generated>
