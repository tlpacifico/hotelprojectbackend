using MicroOrm.Pocos.SqlGenerator.Attributes;
using System;

namespace Model.IlhaBela.Domain.Entity
{
    public class Reserva
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public string NmReserva { get; set; } // nmReserva (length: 120)
        public DateTime DtCheckIn { get; set; } // dtCheckIn
        public DateTime DtCheckOut { get; set; } // dtCheckOut
        public int IdTipoReserva { get; set; } // idTipoReserva
        public string Email { get; set; } // email (length: 40)
        public string DsCelular { get; set; } // dsCelular (length: 11)
        public bool? FlZap { get; set; } // flZap
        public string DsObsGeral { get; set; } // dsObsGeral
    }
}
