// <copyright file="UpdatePIEmailRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.OnlineOrder
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using Newtonsoft.Json;

    /// <summary>
    /// Update PI Email Request.
    /// </summary>
    public class UpdatePIEmailRequest : Request
    {
        public UpdatePIEmailRequest(long puid, string transactionId)
        {
            this.Puid = puid;
            this.TransactionId = transactionId;
        }

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

    }
}
