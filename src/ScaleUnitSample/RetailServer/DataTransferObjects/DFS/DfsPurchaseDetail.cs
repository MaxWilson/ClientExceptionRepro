// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DfsPurchaseDetail.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   The details of purchase for DFS Authorization.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.Library.DellFinanceService.DFS.DataModel
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The details of purchase for DFS Authorization.
    /// </summary>
    [DataContract]
    public class DfsPurchaseDetail
    {
        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        [DataMember]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the total for this line of purchase.
        /// </summary>
        [DataMember]
        public decimal? LineItemTotal { get; set; }

        /// <summary>
        /// Gets or sets the line sequence number.
        /// </summary>
        [DataMember]
        public int? LineSequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [DataMember]
        public decimal? Price { get; set; }

        /// <summary>
        /// Gets or sets the product description.
        /// </summary>
        [DataMember]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        [DataMember]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Gets or sets the Stock Keeping Unit.
        /// </summary>
        [DataMember]
        public string Sku { get; set; }
    }
}