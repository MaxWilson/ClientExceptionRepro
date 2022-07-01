// <copyright file="TaxInvoiceRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.Tax
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// Contains the request data from the tax invoice request API.
    /// </summary>
    [DataContract]
    public class TaxInvoiceRequest : Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxInvoiceRequest"/> class.
        /// </summary>
        /// <param name="transactionId">The transaction ID the tax invoice is for.</param>
        /// <param name="salesId">The sales ID the tax invoice is for.</param>
        /// <param name="taxInvoiceId">The tax invoice ID.</param>
        /// <param name="isRefund">Whether or not the tax invoice is for a refund.</param>
        /// <param name="quantityGroupId">Quantity group id.</param>
        public TaxInvoiceRequest(string transactionId, string salesId, string taxInvoiceId, bool isRefund, string quantityGroupId)
        {
            if (string.IsNullOrWhiteSpace(transactionId))
            {
                throw new System.ArgumentException("message", nameof(transactionId));
            }

            if (string.IsNullOrWhiteSpace(salesId))
            {
                throw new System.ArgumentException("message", nameof(salesId));
            }

            if (string.IsNullOrWhiteSpace(taxInvoiceId))
            {
                throw new System.ArgumentException("message", nameof(taxInvoiceId));
            }

            if (string.IsNullOrWhiteSpace(quantityGroupId))
            {
                throw new System.ArgumentException("message", nameof(quantityGroupId));
            }

            this.TransactionId = transactionId;
            this.SalesId = salesId;
            this.TaxInvoiceId = taxInvoiceId;
            this.IsRefund = isRefund;
            this.QuantityGroupId = quantityGroupId;
        }

        /// <summary>
        /// Gets the Transaction ID the tax invoice is for.
        /// </summary>
        public string TransactionId { get; private set; }

        /// <summary>
        /// Gets the sales id the tax invoice is for.
        /// </summary>
        public string SalesId { get; private set; }

        /// <summary>
        /// Gets the tax InvoiceId.
        /// </summary>
        public string TaxInvoiceId { get; private set; }

        /// <summary>
        /// Gets a value indicating whether or not this tax invoice represents a refund.
        /// </summary>
        public bool IsRefund { get; private set; }

        /// <summary>
        /// Gets Quantity Group Id.
        /// </summary>
        public string QuantityGroupId { get; private set; }
    }
}
