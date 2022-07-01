// <copyright file="SearchCustomerCartsRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    public class OnlineStoreCopyRequest : Request
    {
        public OnlineStoreCopyRequest(string cartId, CartType targetCartType)
        {
            CartId = cartId;
            TargetCartType = targetCartType;
        }

        public string CartId { get; }
        public CartType TargetCartType { get; }
    }
}
