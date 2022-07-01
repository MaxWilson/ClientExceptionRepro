// <copyright file="PaymentLine.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.DellFinanceService.DFS.DataModel.Capture
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Payment line contract used in DFS request.
    /// </summary>
    [DataContract]
    public class PaymentLine
    {
        /// <summary>
        /// Gets or sets the authorization.
        /// </summary>
        [DataMember]
        public string Authorization { get; set; }

        /// <summary>
        /// Gets or sets the DPAAccountNumber.
        /// </summary>
        [DataMember]
        public string DPAAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the Amount.
        /// </summary>
        [DataMember]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the DPARequestType.
        /// </summary>
        [DataMember]
        public string DPARequestType { get; set; }
    }
}
