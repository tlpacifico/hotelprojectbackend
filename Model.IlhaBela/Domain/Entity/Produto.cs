using MicroOrm.Pocos.SqlGenerator.Attributes;

namespace Model.IlhaBela.Domain.Entity
{
    public class Produto
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public string Nome { get; set; } // nome (length: 20)
        public int QtdProduto { get; set; } // qtdProduto
        public decimal VlProduto { get; set; } // vlProduto
    }
}
