using MicroOrm.Pocos.SqlGenerator.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.IlhaBela.Domain.Entity
{
    public class HospedagemHospede
    {
        [KeyProperty]
        public int IdHospedagem { get; set; } // idHospedagem (Primary key)
        [KeyProperty]
        public int IdHospede { get; set; } // idHospede (Primary key)
    }
}
