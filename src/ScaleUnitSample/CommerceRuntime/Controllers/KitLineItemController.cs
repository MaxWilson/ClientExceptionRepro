// <copyright file="CreateOrderFromCartTrigger.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace MSE.D365.RetailServer.Extensions
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;
    using global::MSE.D365.Library.DynamicKit;
    using Microsoft.Dynamics.Commerce.Runtime;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;

    [ComVisible(false)]
    [BindEntity(typeof(KitLineItem))]
    [RoutePrefix("KitLineItem")]
    public class KitLineItemController : IController
    {
        /// <summary>
        /// Gets the product document of DynamicKit.
        /// </summary>
        /// <param name="parameters">id: string representing the bigId of the product.</param>
        /// <returns>Kit product.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Device, CommerceRoles.Application, CommerceRoles.Anonymous, CommerceRoles.Customer)]
        public async Task<PagedResult<KitLineItem>> GetDynamicKit(IEndpointContext ctx, string id)
        {
            return new PagedResult<KitLineItem>(new List<KitLineItem>().AsReadOnly());
        }

        /// <summary>
        /// Gets the product document of DynamicKit by ReleasedProductRecId.
        /// </summary>
        /// <param name="parameters">releasedProductRecId: string representing the releasedProductRecId of the product.</param>
        /// <param name="id">Release Product Record Id</param>
        /// <returns>Kit product.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Device, CommerceRoles.Application, CommerceRoles.Anonymous, CommerceRoles.Customer)]
        public async Task<PagedResult<KitLineItem>> GetDynamicKitByReleasedProductRecId(IEndpointContext ctx, long id)
        {
            return new PagedResult<KitLineItem>(new List<KitLineItem>().AsReadOnly());
        }

        /// <summary>
        /// Gets the product document of DynamicKit by ReleasedProductRecId.
        /// </summary>
        /// <param name="parameters">releasedProductRecId: string representing the releasedProductRecId of the product.</param>
        /// <param name="ids">Release Product Record Ids.</param>
        /// <returns>Kit product.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Device, CommerceRoles.Application, CommerceRoles.Anonymous, CommerceRoles.Customer)]
        public async Task<PagedResult<KitLineItem>> GetDynamicKitByReleasedProductRecIds(IEndpointContext ctx, IEnumerable<long> releasedProductRecIds)
        {
            return new PagedResult<KitLineItem>(new List<KitLineItem>().AsReadOnly());
        }

        /// <summary>
        /// Gets the product document of DynamicKit by any of the P/S/A combination.
        /// </summary>
        /// <param name="parameters">List of string representing P/S/A combination.</param>
        /// <param name="ids">PSAs</param>
        /// <returns>Kit product.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Device, CommerceRoles.Application, CommerceRoles.Anonymous, CommerceRoles.Customer)]
        public async Task<PagedResult<KitLineItem>> GetDynamicKitByAnyOfPSA(IEndpointContext ctx, IEnumerable<string> ids)
        {
            return new PagedResult<KitLineItem>(new List<KitLineItem>().AsReadOnly());
        }
    }
}
