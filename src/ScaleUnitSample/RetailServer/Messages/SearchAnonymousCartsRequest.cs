// <copyright file="SearchAnonymousCartsRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    public class SearchAnonymousCartsRequest : Request
    {
        public SearchAnonymousCartsRequest(string muid, string friendlyName, string cartState)
        {
            Muid = muid;
            FriendlyName = friendlyName;
            CartState = cartState;
        }

        public string Muid { get; }

        public string FriendlyName { get; }

        public string CartState { get; }
    }
}
