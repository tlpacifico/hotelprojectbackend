using MicroOrm.Pocos.SqlGenerator.Attributes;


namespace Model.IlhaBela.Domain.Entity
{
    public class TipoPagamento
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public string NmTipoPagamento { get; set; } // nmTipoPagamento (length: 20)

    }
}
