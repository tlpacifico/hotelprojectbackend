using MicroOrm.Pocos.SqlGenerator.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.IlhaBela.Domain.Entity
{
    public class TipoQuarto
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public string DsQuarto { get; set; } // dsQuarto (length: 30)

    }
}
