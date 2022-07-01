using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Dynamics.Commerce.Runtime.Data
{
    /// <summary>
    /// Error codes pulled from Dynamics 365 source code, Microsoft.Dynamics.Commerce.Runtime.Data.DatabaseErrorCodes.
    /// Unfortunately NOT the same as Microsoft.Dynamics.Commerce.Runtime.Data.DatabaseErrorCode.
    /// </summary>
    public enum DatabaseErrorCodes
    {
        /// <summary>
        /// Success
        /// </summary>
        Success = 0,

        /// <summary>
        /// Failure, as defined by e.g. stored procedure [ext].[CREATEUPDATEASYNCCUSTOMERADDRESS]
        /// </summary>
        CriticalError = 100001,
    }
}
