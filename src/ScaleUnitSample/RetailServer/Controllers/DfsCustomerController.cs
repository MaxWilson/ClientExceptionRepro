// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DfsCustomerController.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   Handles DFS requests for mPOS.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.RetailServer.Extensions
{
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;
    using global::MSE.D365.Library.DellFinanceService.DFS.DataModel.LookupCustomer;
    using global::MSE.D365.Library.DellFinanceService.DFS.DataModel.PreAuth;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;

    /// <summary>
    /// Handles DFS requests for mPOS.
    /// </summary>
    [ComVisible(false)]
    [RoutePrefix("DfsCustomer")]
    [BindEntity(typeof(DfsCustomer))]
    public class DfsCustomerController : IController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DfsCustomerController"/> class.
        /// </summary>
        public DfsCustomerController()
        {
        }

        /// <summary>
        /// Return the Dfs customer according to lookup criteria.
        /// </summary>
        /// <param name="parameters">Customer lookup criteria.</param>
        /// <returns>Dfs customer.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<DfsCustomer> LookupCustomer(IEndpointContext ctx, DfsLookupCriteria dfsLookupCriteria)
        {
            ResponseHelper.NullCheck(dfsLookupCriteria, nameof(dfsLookupCriteria));
            return (await ctx.ExecuteAsync<DataResponse<DfsCustomer>>(new DFSCustomerLookupRequest(dfsLookupCriteria)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Authorizes a transaction for DFS.
        /// </summary>
        /// <param name="parameters"> Information to use for authorization of transaction. </param>
        /// <returns> The conditions of authorization for the transaction. </returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<DfsPreAuthorizationResult> PreAuth(IEndpointContext ctx, DfsPreAuthorizationInformation DfsPreAuthorizationInformation)
        {
            ResponseHelper.NullCheck(DfsPreAuthorizationInformation, nameof(DfsPreAuthorizationInformation));
            return (await ctx.ExecuteAsync<DataResponse<DfsPreAuthorizationResult>>(new DFSPreAuthRequest(DfsPreAuthorizationInformation)).ConfigureAwait(false)).Item;
        }

    }
}
