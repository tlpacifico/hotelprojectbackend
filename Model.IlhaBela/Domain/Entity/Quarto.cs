using MicroOrm.Pocos.SqlGenerator.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.IlhaBela.Domain.Entity
{
   public class Quarto
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public int NumAp { get; set; } // numAp
        public int NumAndar { get; set; } // numAndar
        public int IdTipoQuarto { get; set; } // idTipoQuarto
        public string DsAp { get; set; } // dsAp
        public int FlSituacao { get; set; } // flSituacao
        public int? IdHospedagem { get; set; } // idHospedagem

    }
}
