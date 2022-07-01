// <copyright file="CancelSalesLineDetail.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.OnlineRefunds
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;

    /// <summary>
    /// Initializes a new instance of the <see cref="CancelSalesLineDetail"/> class.
    /// </summary>
    [DataContract]
    public class CancelSalesLineDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelSalesLineDetail"/> class.
        /// </summary>
        public CancelSalesLineDetail()
        {
        }

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
    }
}