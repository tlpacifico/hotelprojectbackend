using MicroOrm.Pocos.SqlGenerator.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.IlhaBela.Domain.Entity
{
    public class ReservaQuarto
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public int IdReserva { get; set; } // idReserva
        public int IdQuarto { get; set; } // idQuarto
        public int QtdPessoa { get; set; } // qtdPessoa
        public decimal Valor { get; set; } // valor
    }
}
