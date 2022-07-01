// <copyright file="DynamicKitRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.DynamicKit
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <inheritdoc/>
    public class DynamicKitRequest : Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicKitRequest"/> class.
        /// </summary>
        /// <param name="bigId">BigId.</param>
        public DynamicKitRequest(string bigId)
        {
            this.BigId = bigId;
        }

        /// <summary>
        /// Gets BigId to search Dynamic Kit.
        /// </summary>
        public string BigId { get; private set; }
    }
}
