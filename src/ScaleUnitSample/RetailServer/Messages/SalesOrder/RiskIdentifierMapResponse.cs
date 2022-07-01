// <copyright file="RiskIdentifierMapResponse.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.MSE.D365.CommerceRuntime.Extensions
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// RiskIdentifierMapResponse.
    /// </summary>
    public class RiskIdentifierMapResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskIdentifierMapResponse"/> class.
        /// </summary>
        /// <param name="transactionId"> Customer Account number.</param>
        public RiskIdentifierMapResponse(string transactionId)
        {
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Gets or Sets the transaction id.
        /// </summary>
        public string TransactionId { get; set; }
    }
}
