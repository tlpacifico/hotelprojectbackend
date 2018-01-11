
using MicroOrm.Pocos.SqlGenerator.Attributes;

namespace Domain.Entity
{

    public class Cama
    {
        [KeyProperty(Identity = true)]
        public int Id { get; set; } // id (Primary key)
        public string DsCama { get; set; } // dsCama (length: 30)

    }

}

