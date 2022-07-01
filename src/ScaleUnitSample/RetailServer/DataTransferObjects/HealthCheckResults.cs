using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSE.D365.Library.HealthCheck
{
    /// <summary>
    /// The results of a System Health Check for a particular store.
    /// </summary>
    public class HealthCheckResults
    {
        /// <summary>
        /// Gets or sets status of services the store depends on.
        /// </summary>
        public HealthCheckResult[] Services { get; set; }

        /// <summary>
        /// Gets or sets status of devices used in a particular store.
        /// </summary>
        public HealthCheckResult[] POSDevices { get; set; }

        /// <summary>
        /// Gets or sets info about hardware peripherals (IP addresses) for this store, so that POS can ping those peripherals.
        /// </summary>
        public HardwarePeripheralIP[] HardwarePeripheralInfo { get; set; }
    }
}
