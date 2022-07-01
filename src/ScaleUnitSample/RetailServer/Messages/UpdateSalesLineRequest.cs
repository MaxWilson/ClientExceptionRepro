// <copyright file="UpdateSalesLineRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.OnlineOrder
{
    using System;
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// Online Sales Record Update Request.
    /// </summary>
    [DataContract]
    public class UpdateSalesLineRequest : Request
    {
        /// <summary>
        /// Gets or sets the Sales Id.
        /// </summary>
        public string SalesId { get; set; }

        /// <summary>
        /// Gets or sets the Line Num.
        /// </summary>
        public string LineNum { get; set; }

        /// <summary>
        ///  Gets or sets the Dunning start date.
        /// </summary>
        public DateTimeOffset DunningStartDate { get; set; }

        /// <summary>
        ///  Gets or sets the Dunning Status.
        /// </summary>
        public int DunningStatus { get; set; }

        /// <summary>
        ///  Gets or sets the Dunning Business Event Status.
        /// </summary>
        public int DunningBusinessEventStatus { get; set; }

        /// <summary>
        ///  Gets or sets the Line Amount.
        /// </summary>
        public decimal LineAmount { get; set; }
    }
}
