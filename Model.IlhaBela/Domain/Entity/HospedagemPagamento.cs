using MicroOrm.Pocos.SqlGenerator.Attributes;
using System;


namespace Model.IlhaBela.Domain.Entity
{
    public class HospedagemPagamento
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public int IdHospdagem { get; set; } // idHospdagem
        public DateTime DtPagamento { get; set; } // dtPagamento
        public int QtdDiaria { get; set; } // qtdDiaria
        public decimal VlTotalDiaria { get; set; } // vlTotalDiaria
        public int IdTipoPagamento { get; set; } // idTipoPagamento
        public string ObsPagamento { get; set; } // obsPagamento (length: 200)
        public decimal? VlTotalConsumo { get; set; } // vlTotalConsumo
        public DateTime DtInicioDiaria { get; set; } // dtInicioDiaria
        public DateTime DtFimDiaria { get; set; } // dtFimDiaria
    }
}
