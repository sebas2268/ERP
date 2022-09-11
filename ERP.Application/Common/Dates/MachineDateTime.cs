using ERP.Application.Interfaces.Common.Dates;
using System;

namespace ERP.Application.Common.Dates
{
    public class MachineDateTime : IMachineDateTime
    {
        public DateTime Now => DateTime.Now;
        public DateTime CentralStandardTime => TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time"));
        public int CurrentYear => DateTime.Now.Year;
    }
}
