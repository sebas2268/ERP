using System;
using System.Collections.Generic;

namespace ERP.Domain.Entities.Maestras
{
    public class Maestra
    {
        public string nmmaestro { get; set; }
        public string cdmaestro { get; set; }
        public string dsmaestro { get; set; }
        public DateTime? feregistro { get; set; }
        public DateTime? febaja { get; set; }
        public ICollection<DataMaestra> DataMaestra { get; set; }

    }
}
