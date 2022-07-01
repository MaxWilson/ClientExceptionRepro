// <copyright file="SalesOrderDetails.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.MSE.D365.Library
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Sales Order details.
    /// </summary>
    public class SalesOrderDetails
    {
        private List<SalesLineDetails> salesLineDetails = new List<SalesLineDetails>();

        /// <summary>
        /// Gets or sets the order id.
        /// </summary>
        [XmlElement]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the CreatedDateTime.
        /// </summary>
        [XmlElement]
        public string CreatedDateTime { get; set; }

        /// <summary>
        /// Gets the list of sales line details.
        /// </summary>
        [XmlElement]
        public List<SalesLineDetails> SalesLineDetails => this.salesLineDetails;
    }
}