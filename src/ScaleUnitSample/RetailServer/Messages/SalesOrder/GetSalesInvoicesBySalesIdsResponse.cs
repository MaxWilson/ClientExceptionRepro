// <copyright file="GetSalesInvoicesBySalesIdsResponse.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.CommerceRuntime.Extensions.OnlineSalesInvoice
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// Response to handle SalesInvoice.
    /// </summary>
    [DataContract]
    public class GetSalesInvoicesBySalesIdsResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSalesInvoicesBySalesIdsResponse"/> class.
        /// </summary>
        /// <param name="invoices">SalesInvoice.</param>
        public GetSalesInvoicesBySalesIdsResponse(List<SalesInvoice> invoices)
        {
            this.SalesInvoices = invoices;
        }

        /// <summary>
        /// Gets list of SalesInvoices with SalesInvoiceLines.
        /// </summary>
        [DataMember]
        public List<SalesInvoice> SalesInvoices { get; }
    }
}
