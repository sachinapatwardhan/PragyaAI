using System;
using System.Collections.Generic;
using System.Text;

namespace PragyaAI.Application.Interfaces.Services
{
    public interface IDateTimeProvider
    {
        DateTime UtcNow { get; }
    }
}
