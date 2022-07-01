// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DfsCaptureResult.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   Result of the DFS capture API call.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.Library.DellFinanceService.DFS.DataModel.Capture
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Result of the DFS capture API call.
    /// </summary>
    [DataContract]
    public class DfsCaptureResult
    {
        /// <summary>
        /// Gets or sets the authorization.
        /// </summary>
        [DataMember]
        public string Authorization { get; set; }

        /// <summary>
        /// Gets or sets a message combined of decision type, decision description, decision date time and error message.
        /// </summary>
        [DataMember]
        public string ExceptionMessage { get; set; }
    }
}