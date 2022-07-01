// <copyright file="RiskIdentifierMapRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.MSE.D365.CommerceRuntime.Extensions
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// RiskIdentifierMapRequest.
    /// </summary>
    public class RiskIdentifierMapRequest : Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskIdentifierMapRequest"/> class.
        /// </summary>
        /// <param name="riskId">returns order RiskId.</param>
        public RiskIdentifierMapRequest(string riskId)
        {
            this.RiskId = riskId;
        }

        /// <summary>
        /// Gets or sets the RiskId.
        /// </summary>
        public string RiskId { get; set; }
    }
}
