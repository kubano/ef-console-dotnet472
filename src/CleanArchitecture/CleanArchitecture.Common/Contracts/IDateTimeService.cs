using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Common
{
    public interface IDateTimeService
    {
        DateTime DtNow { get; }
    }
}