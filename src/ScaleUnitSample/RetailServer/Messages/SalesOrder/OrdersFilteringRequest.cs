// <copyright file="OrdersFilteringRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.MSE.D365.CommerceRuntime.Extensions
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// OrdersFilteringRequest.
    /// </summary>
    public class OrdersFilteringRequest : Request
    {
        public OrdersFilteringRequest(string custAccount, string paymentInstrumentId)
        {
            this.CustAccount = custAccount;
            this.PaymentInstrumentId = paymentInstrumentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersFilteringRequest"/> class.
        /// </summary>
        /// <param name="custAccount">Customer account number.</param>
        /// <param name="billingStates">Billing states.</param>
        /// <param name="fulfillmentStates">Fulfillment states.</param>
        /// <param name="paymentInstrumentId">Payment instrument id.</param>
        /// <param name="recurrenceId">Recurrene id.</param>
        public OrdersFilteringRequest(string custAccount, string billingStates, string fulfillmentStates, string paymentInstrumentId, string recurrenceId)
        {
            this.CustAccount = custAccount;
            this.BillingStates = billingStates;
            this.FulfillmentStates = fulfillmentStates;
            this.PaymentInstrumentId = paymentInstrumentId;
            this.RecurrenceId = recurrenceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersFilteringRequest"/> class.
        /// </summary>
        /// <param name="puid">Custmer Identifier.</param>
        /// <param name="paymentInstrumentId">Payment instrument id.</param>
        public OrdersFilteringRequest(long puid, string paymentInstrumentId)
        {
            this.Puid = puid;
            this.PaymentInstrumentId = paymentInstrumentId;
        }

        /// <summary>
        /// Gets or sets the billing states.
        /// </summary>
        public string BillingStates { get; set; }

        /// <summary>
        /// Gets or sets the fulfillment states.
        /// </summary>
        public string FulfillmentStates { get; set; }

        /// <summary>
        /// Gets or sets the payment instrument id.
        /// </summary>
        public string PaymentInstrumentId { get; set; }

        /// <summary>
        /// Gets or sets the recurrence id.
        /// </summary>
        public string RecurrenceId { get; set; }

        /// <summary>
        /// Gets or sets the customer account number.
        /// </summary>
        public string CustAccount { get; set; }

        /// <summary>
        /// Gets or sets the customer PUID.
        /// </summary>
        public long Puid { get; set; }
    }
}
