using MicroOrm.Pocos.SqlGenerator.Attributes;
using System;

namespace Model.IlhaBela.Domain.Entity
{
    public class ReservaAgendamento
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public int? IdReservaQuarto { get; set; } // idReservaQuarto
        public int IdQuarto { get; set; } // idQuarto
        public int? IdHospdagem { get; set; } // idHospdagem
        public DateTime DtCheckIn { get; set; } // dtCheckIn
        public DateTime? DtCheckOut { get; set; } // dtCheckOut
    }
}
