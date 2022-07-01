using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSE.D365.Library.HealthCheck
{
    public class HealthCheckResult
    {
        public string Name { get; set; }
        public bool IsOk { get; set; }
        public string ErrorMsg { get; set; }
    }
}
