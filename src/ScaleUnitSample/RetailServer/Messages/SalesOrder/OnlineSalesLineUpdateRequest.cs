// <copyright file="OnlineSalesLineUpdateRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.MSE.D365.Library
{
    using System;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using Newtonsoft.Json;

    /// <summary>
    /// Online SalesLine Update Request.
    /// </summary>
    public class OnlineSalesLineUpdateRequest : Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineSalesLineUpdateRequest"/> class.
        /// </summary>
        /// <param name="transactionId">Transaction Id.</param>
        /// <param name="lineNumber">Line number.</param>
        public OnlineSalesLineUpdateRequest(string transactionId, decimal lineNumber)
        {
            this.TransactionId = transactionId;
            this.LineNumber = lineNumber;
        }

        /// <summary>
        /// Gets or sets the transaction id.
        /// </summary>
        [JsonProperty("transactionId", Required = Required.Always)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the line number.
        /// </summary>
        [JsonProperty("lineNumber", Required = Required.Always)]
        public decimal LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the fulfillment id.
        /// </summary>
        [JsonProperty("fulfillmentId")]
        public string FulfillmentId { get; set; }

        /// <summary>
        /// Gets or sets the billing state.
        /// </summary>
        [JsonProperty("billingState")]
        public string BillingState { get; set; }

        /// <summary>
        /// Gets or sets the fulfillment state.
        /// </summary>
        [JsonProperty("fulfillmentState")]
        public string FulfillmentState { get; set; }

        /// <summary>
        /// Gets or sets the authorization request id.
        /// </summary>
        [JsonProperty("authorizationRequestId")]
        public string AuthorizationRequestId { get; set; }

        /// <summary>
        /// Gets or sets the Refunded reason.
        /// </summary>
        [JsonProperty("refundedReason")]
        public string RefundedReason { get; set; }

        /// <summary>
        /// Gets or sets the Refunded DateTime Offset.
        /// </summary>
        [JsonProperty("refundedDateTimeOffset")]
        public DateTimeOffset? RefundedDateTimeOffset { get; set; }

        /// <summary>
        /// Gets or sets the refunded amount including tax.
        /// </summary>
        [JsonProperty("refundedTotalAmount")]
        public decimal? RefundedTotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the refunded tax amount.
        /// </summary>
        [JsonProperty("refundedTaxAmount")]
        public decimal? RefundedTaxAmount { get; set; }

        /// <summary>
        /// Gets or sets the Canceled reason.
        /// </summary>
        [JsonProperty("canceledReason")]
        public string CanceledReason { get; set; }

        /// <summary>
        /// Gets or sets the Canceled DateTime Offset.
        /// </summary>
        [JsonProperty("canceledDateTimeOffset")]
        public DateTimeOffset? CanceledDateTimeOffset { get; set; }

        /// <summary>
        /// Gets or sets the Returned reason.
        /// </summary>
        [JsonProperty("returnedReason")]
        public string ReturnedReason { get; set; }

        /// <summary>
        /// Gets or sets the Returned DateTime Offset.
        /// </summary>
        [JsonProperty("returnedDateTimeOffset")]
        public DateTimeOffset? ReturnedDateTimeOffset { get; set; }

        /// <summary>
        /// Gets or sets the Rma Id.
        /// </summary>
        [JsonProperty("rmaId")]
        public string RmaId { get; set; }

        /// <summary>
        /// Gets or sets the Serial number.
        /// </summary>
        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        ///  <summary>
        ///  Gets or sets the OC Fulfillment Session Id.
        ///  </summary>
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        ///  <summary>
        ///  Gets or sets the Json represenation of Tracking Ids object.
        ///  </summary>
        [JsonProperty("jsonTrackingId")]
        public string JsonTrackingId { get; set; }

        ///  <summary>
        ///  Gets or sets the OC Fulfillment shipping PlantId.
        ///  </summary>
        [JsonProperty("shippingPlantId")]
        public string ShippingPlantId { get; set; }

        ///  <summary>
        ///  Gets or sets the comment for fulfillment.
        ///  </summary>
        [JsonProperty("fulfillmentComment")]
        public string FulfillmentComment { get; set; }

        ///// <summary>
        ///// Gets or sets the FulfillmentRetryCheckDate for fulfillment.
        ///// </summary>
        [JsonProperty("FulfillmentRetryCheckDate")]
        public DateTime? FulfillmentRetryCheckDate { get; set; }

        ///  <summary>
        ///  Gets or sets the fulfillment Retry Count for fulfillment.
        ///  </summary>
        [JsonProperty("fulfillmentRetryCount")]
        public int? FulfillmentRetryCount { get; set; }

        /// <summary>
        /// Gets or sets the FulfilledDate once fulfillment is complete.
        /// </summary>
        [JsonProperty("FulfilledDate")]
        public DateTime? FulfilledDate { get; set; }
    }
}
