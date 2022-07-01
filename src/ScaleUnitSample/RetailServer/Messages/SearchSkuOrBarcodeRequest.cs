// <copyright file="SearchCustomerCartsRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    public class SearchSkuOrBarcodeRequest : Request
    {
        public SearchSkuOrBarcodeRequest(string searchText)
        {
            SearchText = searchText;
        }

        public string SearchText { get; }
    }
}
