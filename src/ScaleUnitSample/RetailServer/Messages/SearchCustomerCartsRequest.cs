// <copyright file="SearchCustomerCartsRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    public class SearchCustomerCartsRequest : Request
    {
        public SearchCustomerCartsRequest(long puid, string friendlyName, string cartState)
        {
            this.Puid = puid;
            this.FriendlyName = friendlyName;
            this.CartState = cartState;
        }

        public long Puid { get; }

        public string FriendlyName { get; }

        public string CartState { get; }
    }
}
