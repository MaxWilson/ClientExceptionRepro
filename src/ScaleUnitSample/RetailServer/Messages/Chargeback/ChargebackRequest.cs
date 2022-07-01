// <copyright file="ChargebackRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.Chargeback
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// Contains the payload necessary for calling the chargeback API in the retail transaction service extensions.
    /// </summary>
    public class ChargebackRequest : Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargebackRequest"/> class.
        /// </summary>
        /// <param name="invoiceId">The invoice the chargeback is for.</param>
        /// <param name="referenceId">The reference of the chargeback event itself, external identifier.</param>
        /// <param name="amount">The amount of the chargeback.</param>
        public ChargebackRequest(string invoiceId, string referenceId, decimal amount)
        {
            if (string.IsNullOrWhiteSpace(invoiceId))
            {
                throw new System.ArgumentException("message", nameof(invoiceId));
            }

            if (string.IsNullOrWhiteSpace(referenceId))
            {
                throw new System.ArgumentException("message", nameof(referenceId));
            }

            this.InvoiceId = invoiceId;
            this.ReferenceId = referenceId;
            this.Amount = amount;
        }

        /// <summary>
        /// Gets the Invoice ID of the original invoice the chargeback is for.
        /// </summary>
        public string InvoiceId { get; private set; }

        /// <summary>
        /// Gets the external reference ID for the chargeback.
        /// </summary>
        public string ReferenceId { get; private set; }

        /// <summary>
        /// Gets the amount of the chargeback.
        /// </summary>
        public decimal Amount { get; private set; }
    }
}
