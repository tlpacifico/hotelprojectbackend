using MicroOrm.Pocos.SqlGenerator.Attributes;
using System;


namespace Model.IlhaBela.Domain.Entity
{
   public class HospedagemConsumo
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public int IdHospedagem { get; set; } // idHospedagem
        public int IdProduto { get; set; } // idProduto
        public int QtdProduto { get; set; } // qtdProduto
        public DateTime DtConsumo { get; set; } // dtConsumo
        public string ObsConsumo { get; set; } // obsConsumo (length: 140)
        public bool FlPagamento { get; set; } // flPagamento
    }
}
