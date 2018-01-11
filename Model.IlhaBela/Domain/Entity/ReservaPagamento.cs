using MicroOrm.Pocos.SqlGenerator.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.IlhaBela.Domain.Entity
{
    public class ReservaPagamento
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public int IdReserva { get; set; } // idReserva
        public DateTime DtPagamento { get; set; } // dtPagamento
        public decimal VlPago { get; set; } // vlPago
        public string ObsPagamento { get; set; } // obsPagamento (length: 1)
    }
}
