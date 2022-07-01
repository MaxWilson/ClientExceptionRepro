// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DfsPreAuthorizationResult.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   The dfs pre auth result.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.Library.DellFinanceService.DFS.DataModel.PreAuth
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The DFS pre authentication result.
    /// </summary>
    [DataContract]
    public class DfsPreAuthorizationResult
    {
        /// <summary>
        /// Gets or sets the promotional code.
        /// </summary>
        [DataMember]
        public string PromotionalCode { get; set; }

        /// <summary>
        /// Gets or sets the promotional description.
        /// </summary>
        [DataMember]
        public string PromotionalDescription { get; set; }

        /// <summary>
        /// Gets or sets the total financed amount.
        /// </summary>
        [DataMember]
        public decimal TotalFinancedAmount { get; set; }

        /// <summary>
        /// Gets or sets the decision type.
        /// </summary>
        [DataMember]
        public string DecisionType { get; set; }

        /// <summary>
        /// Gets or sets the decision description.
        /// </summary>
        [DataMember]
        public string DecisionDescription { get; set; }

        /// <summary>
        /// Gets or sets the transaction id.
        /// </summary>
        [DataMember]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        [DataMember]
        public string ErrorMessage { get; set; }
    }
}