using System;

namespace ERP.Application.Interfaces.Common.Dates
{
    public interface IMachineDateTime
    {
        DateTime Now { get; }
        DateTime CentralStandardTime { get; }
        int CurrentYear { get; }
    }
}
