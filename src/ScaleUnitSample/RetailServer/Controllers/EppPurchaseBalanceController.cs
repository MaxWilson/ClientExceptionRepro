// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EppPurchaseBalanceController.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   Defines the EppPurchaseBalanceController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.RetailServer.Extensions
{
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;
    using Microsoft.MSE.D365.Library.EPP;

    /// <summary>
    /// Handles the API requests for <see cref="EppPurchaseBalance"/> entity.
    /// </summary>
    [ComVisible(false)]
    [RoutePrefix("EppPurchaseBalance")]
    [BindEntity(typeof(EppPurchaseBalance))]
    public class EppPurchaseBalanceController : IController
    {
        /// <summary>
        /// Returns the EppPurchaseBalance for the given id.
        /// </summary>
        [HttpPost]
        [Authorization(CommerceRoles.Customer, CommerceRoles.Device, CommerceRoles.Employee)]
        public async Task<EppPurchaseBalance> GetEppPurchaseBalance(IEndpointContext ctx, string id)
        {
            ResponseHelper.NullCheck(id, nameof(id));
            return (await ctx.ExecuteAsync<DataResponse<EppPurchaseBalance>>(new GetEppPurchaseBalanceRequest(id))).Item;
        }
    }
}