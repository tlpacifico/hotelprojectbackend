using MicroOrm.Pocos.SqlGenerator.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.IlhaBela.Domain.Entity
{
    public class QuartoCama
    {
        [KeyProperty]
        public int IdQuarto { get; set; } // idQuarto (Primary key)
        [KeyProperty]
        public int IdCama { get; set; } // idCama (Primary key)
        public int QtdCama { get; set; } // qtdCama
    }
}
