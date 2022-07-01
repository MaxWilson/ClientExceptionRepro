// <copyright file="FilterCartIdsRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.CartExport
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// Filter a list of cartIds against a list of already-accepted cartIds to remove already-accepted carts.
    /// </summary>
    public class FilterCartIdsRequest : Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterCartIdsRequest"/> class.
        /// </summary>
        /// <param name="cartId">Cart ID, e.g. 1092-10924011-217.</param>
        public FilterCartIdsRequest(string cartId)
        {
            this.CartId = cartId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterCartIdsRequest"/> class.
        /// </summary>
        /// <param name="puid">Customer PUID, e.g. 11111111111.</param>
        public FilterCartIdsRequest(long puid)
        {
            this.Puid = puid;
        }

        /// <summary>
        /// Gets cart id, if set.
        /// </summary>
        public string CartId { get; }

        /// <summary>
        /// Gets Puid, if set.
        /// </summary>
        public long? Puid { get; }
    }
}
