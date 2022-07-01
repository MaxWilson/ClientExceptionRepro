// <copyright file="SearchCustomerCartsRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    public class SearchEppCustomerRequest : Request
    {
        public SearchEppCustomerRequest(string email)
        {
            Email = email;
        }

        public string Email { get; }
    }
}
