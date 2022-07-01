// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DfsCaptureInformation.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   The DFS capture information as received from POS.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.Library.DellFinanceService.DFS.DataModel.Capture
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// The DFS capture information as received from mPOS.
    /// </summary>
    [DataContract]
    public class DfsCaptureInformation
    {
        /// <summary>
        /// Gets or sets the tender line.
        /// </summary>
        [DataMember]
        public PaymentLine PaymentLine { get; set; }

        /// <summary>
        /// Gets or sets the transaction id.
        /// </summary>
        [DataMember]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the return transaction id.
        /// </summary>
        [DataMember]
        public string ReturnTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the total purchase amount.
        /// </summary>
        [DataMember]
        public decimal? TotalPurchaseAmount { get; set; }

        /// <summary>
        /// Gets or sets the purchase details.
        /// </summary>
        [DataMember]
        public IList<DfsPurchaseDetail> PurchaseDetails { get; set; }
    }
}