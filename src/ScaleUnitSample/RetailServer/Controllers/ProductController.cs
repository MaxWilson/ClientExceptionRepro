namespace MSE.D365.RetailServer.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.Dynamics.Commerce.Runtime;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;

    /// <inheritdoc/>
    public class ProductController : IController
    {
        public const string GetActivePricesAffiliationIdExtProperty = "AFFILIATIONID";
        public const string GetActivePricesAffiliationNameExtProperty = "AFFILIATIONNAME";

        /// <summary>
        /// Search by SKU or barcode.
        /// </summary>
        /// <param name="parameters">searchText: string</param>
        /// <returns>SKU (a.k.a. ItemId) of the product.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<SimpleProduct> SearchSkuOrBarcode(IEndpointContext ctx, string searchText)
        {
            ResponseHelper.NullCheck(searchText, nameof(searchText));
            return (await ctx.ExecuteAsync<DataResponse<SimpleProduct>>(new SearchSkuOrBarcodeRequest(searchText))).Item;
        }

        [HttpPost]
        [Authorization(CommerceRoles.Anonymous, CommerceRoles.Customer, CommerceRoles.Employee, CommerceRoles.Application)]
        public async Task<PagedResult<ProductPrice>> GetActivePrices(IEndpointContext ctx, ProjectionDomain projectDomain, IEnumerable<long> productIds, DateTimeOffset activeDate, string customerId, bool includeSimpleDiscountsInContextualPrice, IEnumerable<AffiliationLoyaltyTier> affiliationLoyaltyTiers, QueryResultSettings queryResultSettings)
        {
            return (await ctx.ExecuteAsync<DataResponse<PagedResult<ProductPrice>>>(new GetActivePricesRequest(projectDomain, productIds, activeDate, customerId, includeSimpleDiscountsInContextualPrice, affiliationLoyaltyTiers) { QueryResultSettings = queryResultSettings }).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Get all prices for a given set of products.
        /// </summary>
        /// <param name="parameters">Projection Domain (Channel + Catalog), List of ProductIds, ActiveDate, CustomerId, Include simple discounts.</param>
        /// <returns>Product prices.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application, CommerceRoles.Customer)]
        public async Task<PagedResult<ProductPrice>> BulkGetActivePrices(IEndpointContext ctx, ProjectionDomain projectDomain, IEnumerable<long> productIds, DateTimeOffset activeDate, string customerId, bool includeSimpleDiscountsInContextualPrice, QueryResultSettings queryResultSettings)
        {
            return (await ctx.ExecuteAsync<DataResponse<PagedResult<ProductPrice>>>(new BulkGetActivePricesRequest(projectDomain, productIds, activeDate, customerId, includeSimpleDiscountsInContextualPrice) { QueryResultSettings = queryResultSettings }).ConfigureAwait(false)).Item;
        }
    }
}
