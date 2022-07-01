// <copyright file="DFSPreAuthRequest .cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using global::MSE.D365.Library.DellFinanceService.DFS.DataModel.PreAuth;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    public class DFSPreAuthRequest : Request
    {
        public DFSPreAuthRequest()
        {
        }

        public DFSPreAuthRequest(DfsPreAuthorizationInformation dfsPreAuthorizationInformation)
        {
            this.DfsPreAuthorizationInformation = dfsPreAuthorizationInformation;
        }

        public DfsPreAuthorizationInformation DfsPreAuthorizationInformation { get; }
    }
}
