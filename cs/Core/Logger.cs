using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TapstreamMetrics.Sdk
{
    public interface Logger
    {
        void Log(LogLevel level, string msg);
    }
}