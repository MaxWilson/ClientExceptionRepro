// <copyright file="OnlineSalesOrderUpdateRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.MSE.D365.Library
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using Newtonsoft.Json;

    /// <summary>
    /// Online SalesOrder Update Request.
    /// </summary>
    public class OnlineSalesOrderUpdateRequest : Request
    {
        /// <summary>
        /// Gets or sets the puid.
        /// </summary>
        [JsonProperty("puid", Required = Required.Always)]
        public long Puid { get; set; }

        /// <summary>
        /// Gets or sets the transaction id.
        /// </summary>
        [JsonProperty("transactionId", Required = Required.Always)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the primary payment id.
        /// </summary>
        [JsonProperty("primaryPaymentId")]
        public string PrimaryPaymentId { get; set; }
    }
}
