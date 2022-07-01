// <copyright file="AcceptCartRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.CartExport
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// Mark cart as already accepted by cart export systems (MST POBO scenario).
    /// </summary>
    public class AcceptCartRequest : Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptCartRequest"/> class.
        /// </summary>
        /// <param name="cartId">Cart ID, e.g. 1092-10924011-217.</param>
        public AcceptCartRequest(string cartId)
        {
            this.CartId = cartId;
        }

        /// <summary>
        /// Gets list of cart IDs.
        /// </summary>
        public string CartId { get; private set; }
    }
}
