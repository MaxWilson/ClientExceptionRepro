// <copyright file="SalesLineDetailRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.OnlineOrder
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Initializes a new instance of the <see cref="SalesLineDetailRequest"/> class.
    /// </summary>
    [DataContract]
    public class SalesLineDetailRequest
    {
        /// <summary>
        /// Gets or sets a value indicating the sales line to refund.
        /// </summary>
        [DataMember(Name = "lineNum")]
        public string LineNum { get; set; }

        /// <summary>
        /// Gets or sets the value Reason Code.
        /// </summary>
        [DataMember(Name = "reasonCode")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets the value Canceled date.
        /// </summary>
        [DataMember(Name = "canceledDate")]
        public DateTime CanceledDate { get; set; }
    }
}