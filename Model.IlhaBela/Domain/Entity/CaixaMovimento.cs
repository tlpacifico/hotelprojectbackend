using MicroOrm.Pocos.SqlGenerator.Attributes;
using System;


namespace Model.IlhaBela.Domain.Entity
{
    public class CaixaMovimento
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public int? IdHospedagemPagamento { get; set; } // idHospedagemPagamento
        public int? IdProdutoMovimento { get; set; } // idProdutoMovimento
        public int IdTipoOperacao { get; set; } // idTipoOperacao
        public DateTime DtOperacao { get; set; } // dtOperacao
        public decimal VlOperacao { get; set; } // vlOperacao
        public string ObsOperacao { get; set; } // obsOperacao (length: 200)
    }
}
