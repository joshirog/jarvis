using System;
using System.Collections.Generic;

namespace setours.jarvis.transversal.common.Bases.Responses
{
    public class BaseHealthCheckResponse
    {
        public string Status { get; set; }

        public IEnumerable<BaseHealthCheck> Checks { get; set; }

        public TimeSpan Duration { get; set; }
    }
}
