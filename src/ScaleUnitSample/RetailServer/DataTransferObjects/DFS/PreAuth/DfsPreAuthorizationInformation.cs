// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DfsPreAuthorizationInformation.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   Pre transaction authorization request fields for DFS.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.Library.DellFinanceService.DFS.DataModel.PreAuth
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Pre transaction authorization request fields for DFS.
    /// </summary>
    [DataContract]
    public class DfsPreAuthorizationInformation
    {
        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        [DataMember]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the transaction id.
        /// </summary>
        [DataMember]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the total financed amount.
        /// </summary>
        [DataMember]
        public decimal? TotalFinancedAmount { get; set; }

        /// <summary>
        /// Gets or sets the total purchase amount.
        /// </summary>
        [DataMember]
        public decimal? TotalPurchaseAmount { get; set; }

        /// <summary>
        /// Gets or sets the total tax.
        /// </summary>
        [DataMember]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Gets or sets the purchase details.
        /// </summary>
        [DataMember]
        public IList<DfsPurchaseDetail> PurchaseDetails { get; set; }
    }
}