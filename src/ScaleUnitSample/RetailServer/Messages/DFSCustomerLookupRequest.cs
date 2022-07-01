// <copyright file="DFSCustomerLookupRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using global::MSE.D365.Library.DellFinanceService.DFS.DataModel.LookupCustomer;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    public class DFSCustomerLookupRequest : Request
    {
        public DFSCustomerLookupRequest(DfsLookupCriteria dfsLookupCriteria)
        {
            this.DfsLookupCriteria = dfsLookupCriteria;
        }

        public DfsLookupCriteria DfsLookupCriteria { get; internal set; }
    }
}
