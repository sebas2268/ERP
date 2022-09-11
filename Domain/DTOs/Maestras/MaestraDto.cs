using System;

namespace ERP.Domain.DTOs.Maestras
{
    public class MaestraDto
    {
        public string nmmaestro { get; set; }
        public string cdmaestro { get; set; }
        public string dsmaestro { get; set; }
        public DateTime? feregistro { get; set; }
        public DateTime? febaja { get; set; }
    }
}
