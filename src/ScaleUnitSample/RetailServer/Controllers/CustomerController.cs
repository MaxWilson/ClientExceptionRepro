// <copyright file="CustomerController.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;

    // using Microsoft.Dynamics.Retail.RetailServerLibrary.ODataControllers
    // Inherit from default controller to add new oData actions to support EPP scenario.
    //   See https://docs.microsoft.com/en-us/dynamics365/unified-operations/retail/dev-itpro/commerce-runtime-extensibility, "Retail Server extensibility scenarios"
    public class CustomerController : IController
    {
        private const string OperationClass = nameof(CustomerController);

        /// <summary>
        /// EPP scenarios require the ability to auto-create customers from EPP data.
        /// </summary>
        /// <param name="ctx">Endpoint context for accessing CRT.</param>
        /// <returns>Customer's account number.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Customer, CommerceRoles.Device, CommerceRoles.Employee)]
        public async Task<string> TryCreateCustomer(IEndpointContext ctx, string email, string fullName, string firstName, string lastName, string phone)
        {
            return (await ctx.ExecuteAsync<DataResponse<string>>(new TryCreateCustomerRequest(email, fullName, firstName, lastName, phone)).ConfigureAwait(false)).Item;
        }
    }
}
