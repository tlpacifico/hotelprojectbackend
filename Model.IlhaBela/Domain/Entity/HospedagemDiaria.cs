using MicroOrm.Pocos.SqlGenerator.Attributes;
using System;


namespace Model.IlhaBela.Domain.Entity
{
   public class HospedagemDiaria
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public int IdHospedagem { get; set; } // idHospedagem
        public int IdQuarto { get; set; } // idQuarto
        public int NumHospedes { get; set; } // numHospedes
        public DateTime DtDiaria { get; set; } // dtDiaria
        public decimal VlDiaria { get; set; } // vlDiaria
        public bool FlPagamento { get; set; } // flPagamento
    }
}
