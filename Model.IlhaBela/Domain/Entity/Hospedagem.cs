using MicroOrm.Pocos.SqlGenerator.Attributes;
using System;


namespace Model.IlhaBela.Domain.Entity
{
   public class Hospedagem
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public DateTime DtCheckIn { get; set; } // dtCheckIn
        public DateTime DtCheckOut { get; set; } // dtCheckOut
        public int IdQuartoAtual { get; set; } // idQuartoAtual
        public int NumHospedes { get; set; } // numHospedes
        public int? IdPreReserva { get; set; } // idPreReserva
        public string IdUserCheckIn { get; set; } // idUserCheckIn (length: 120)
        public string IdUserCheckOut { get; set; } // idUserCheckOut (length: 120)
        public decimal VlDiariaAtual { get; set; } // vlDiariaAtual
        public decimal? VlFechamentoConta { get; set; } // vlFechamentoConta
    }
}
