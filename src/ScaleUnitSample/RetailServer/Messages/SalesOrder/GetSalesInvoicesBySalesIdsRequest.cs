// <copyright file="GetSalesInvoicesBySalesIdsRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.CommerceRuntime.Extensions.OnlineSalesInvoice
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// Request to handle SalesInvoice get request.
    /// </summary>
    public class GetSalesInvoicesBySalesIdsRequest : Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSalesInvoicesBySalesIdsRequest"/> class.
        /// </summary>
        /// <param name="salesIds">salesIds.</param>
        public GetSalesInvoicesBySalesIdsRequest(string salesIds)
        {
            this.SalesIds = salesIds;
        }

        /// <summary>
        /// Gets Sales IDs.
        /// </summary>
        public string SalesIds { get; }
    }
}
