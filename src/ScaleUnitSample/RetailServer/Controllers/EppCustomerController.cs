// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EppCustomerController.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   Defines the EppCustomerController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.RetailServer.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;
    using global::MSE.D365.Library.Telemetry;
    using Microsoft.Dynamics.Commerce.Runtime;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;
    using Microsoft.MSE.D365.Library.EPP;

    /// <summary>
    /// Handles the API requests for <see cref="EppCustomer"/> entity.
    /// </summary>
    [ComVisible(false)]
    [RoutePrefix("EppCustomer")]
    [BindEntity(typeof(EppCustomer))]
    public class EppCustomerController : IController
    {
        /// <summary>
        /// Returns the EppCustomer for the given id.
        /// </summary>
        /// <returns>Epp Customer data.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Customer, CommerceRoles.Device, CommerceRoles.Employee)]
        public async Task<EppCustomer> GetEppCustomer(IEndpointContext ctx, string id)
        {
            ResponseHelper.NullCheck(id, nameof(id));
            return (await ctx.ExecuteAsync<DataResponse<EppCustomer>>(new GetEppCustomerRequest(id))).Item;
        }

        /// <summary>
        /// Searches for EppCustomers with match email address.
        /// </summary>
        /// <returns>List matching EPP customers.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Customer, CommerceRoles.Device, CommerceRoles.Employee)]
        public async Task<PagedResult<EppCustomer>> SearchEppCustomer(IEndpointContext ctx, string email)
        {
            ResponseHelper.NullCheck(email, nameof(email));
            return (await ctx.ExecuteAsync<DataResponse<EppCustomer[]>>(new SearchEppCustomerRequest(email))).Item.ToPagedResult();
        }
    }
}
