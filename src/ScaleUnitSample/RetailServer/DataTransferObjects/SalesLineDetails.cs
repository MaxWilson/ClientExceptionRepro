// <copyright file="SalesLineDetails.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.MSE.D365.Library
{
    using System.Xml.Serialization;

    /// <summary>
    /// Sales Line Details.
    /// </summary>
    public class SalesLineDetails
    {
        /// <summary>
        /// Gets or sets the line id.
        /// </summary>
        [XmlElement]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Billing state.
        /// </summary>
        [XmlElement]
        public string BillingState { get; set; }

        /// <summary>
        /// Gets or sets the FulfillmentState.
        /// </summary>
        [XmlElement]
        public string FulfillmentState { get; set; }
    }
}