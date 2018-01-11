using MicroOrm.Pocos.SqlGenerator.Attributes;

namespace Model.IlhaBela.Domain.Entity
{
    public class TipoOperacao
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public string NmTipoOperacao { get; set; } // nmTipoOperacao (length: 20)
        public string DsOperacao { get; set; } // dsOperacao (length: 200)
    }
}
