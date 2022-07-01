// <copyright file="RefundSalesLineDetail.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.OnlineRefunds
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;

    /// <summary>
    /// Initializes a new instance of the <see cref="RefundSalesLineDetail"/> class.
    /// </summary>
    [DataContract]
    public class RefundSalesLineDetail : CommerceEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundSalesLineDetail"/> class.
        /// </summary>
        public RefundSalesLineDetail()
            : base(nameof(RefundSalesLineDetail))
        {
        }

        /// <summary>
        /// Gets or sets a value indicating the sales line to refund.
        /// </summary>
        [DataMember(Name = "lineNum")]
        public string LineNum { get; set; }

        /// <summary>
        /// Gets or sets the value indicating the partial amount to refund.
        /// Legal entity determines if tax inclusive.
        /// </summary>
        [DataMember(Name = "partialRefundAmount")]
        public decimal? PartialRefundAmount { get; set; }

        /// <summary>
        /// Gets or sets the value Reason Code.
        /// </summary>
        [DataMember(Name = "reasonCode")]
        public string ReasonCode { get; set; } = string.Empty;
    }
}