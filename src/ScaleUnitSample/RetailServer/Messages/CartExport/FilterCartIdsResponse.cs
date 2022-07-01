// <copyright file="FilterCartIdsResponse.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.CartExport
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// Response for FilterCartIds request, returns list of cart IDs which have not already been accepted.
    /// </summary>
    public class FilterCartIdsResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterCartIdsResponse"/> class.
        /// </summary>
        /// <param name="cartIds">Cart IDs, e.g. 1092-10924011-217.</param>
        public FilterCartIdsResponse(string[] cartIds)
        {
            this.CartIds = cartIds;
        }

        /// <summary>
        /// Gets list of cart IDs.
        /// </summary>
        public string[] CartIds { get; private set; }
    }
}
