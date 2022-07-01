// <copyright file="SearchCustomerCartsRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    public class GetEppCustomerRequest : Request
    {
        public GetEppCustomerRequest(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
