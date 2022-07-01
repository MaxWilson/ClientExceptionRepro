// <copyright file="OrdersFilteringResponse.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.MSE.D365.CommerceRuntime.Extensions
{
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using Microsoft.MSE.D365.Library;

    /// <summary>
    /// Orders Filtering Response.
    /// </summary>
    [XmlRoot(ElementName = "OrderDetailsList")]
    public class OrdersFilteringResponse : Response
    {
        private List<SalesOrderDetails> salesOrderDetails = new List<SalesOrderDetails>();

        /// <summary>
        /// Gets the list of sales order details.
        /// </summary>
        [XmlElement]
        public List<SalesOrderDetails> SalesOrderDetails => this.salesOrderDetails;
    }
}