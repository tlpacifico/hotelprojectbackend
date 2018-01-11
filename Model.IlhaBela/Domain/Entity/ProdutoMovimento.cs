using MicroOrm.Pocos.SqlGenerator.Attributes;


namespace Model.IlhaBela.Domain.Entity
{
    public  class ProdutoMovimento
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public int IdProduto { get; set; } // idProduto       
        public int idTipoMovimento { get; set; } // tpMovimento (length: 1)
        public int QtdProduto { get; set; } // qtdProduto
        public System.DateTime DtMovimento { get; set; } // dtMovimento
        public decimal VlTotal { get; set; } // vlTotal

    }
}
