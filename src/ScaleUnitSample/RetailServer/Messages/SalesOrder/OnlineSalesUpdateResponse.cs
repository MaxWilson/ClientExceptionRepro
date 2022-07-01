// <copyright file="OnlineSalesUpdateResponse.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.MSE.D365.Library
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using Newtonsoft.Json;

    /// <summary>
    /// Online SalesLine Update Response.
    /// </summary>
    public class OnlineSalesUpdateResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineSalesUpdateResponse"/> class.
        /// </summary>
        /// <param name="transactionId">Transaction Id.</param>
        public OnlineSalesUpdateResponse(string transactionId)
        {
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineSalesUpdateResponse"/> class.
        /// </summary>
        /// <param name="transactionId">Transaction Id.</param>
        /// <param name="puid">PUID.</param>
        public OnlineSalesUpdateResponse(string transactionId, string puid)
        {
            this.TransactionId = transactionId;
            this.Puid = puid;
        }

        /// <summary>
        /// Gets or Sets the transactionId.
        /// </summary>
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets the puid.
        /// </summary>
        [JsonProperty("puid")]
        public string Puid { get; set; }
    }
}
