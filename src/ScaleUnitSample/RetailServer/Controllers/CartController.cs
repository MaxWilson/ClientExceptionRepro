// <copyright file="CartController.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.Dynamics.Commerce.Runtime;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using Microsoft.Dynamics.Commerce.Runtime.Services.Messages;

    /// <summary>
    /// Add custom operations to Carts collection.
    /// </summary>
    public class CartController : IController
    {
        /// <summary>
        /// Search for cart by PUID and friendly name.
        /// </summary>
        /// <param name="puid">Customer account number.</param>
        /// <param name="friendlyName">Filter on FriendlyName extended property (for online sales). Null or empty string means no filter.</param>
        /// <param name="cartState">Filter on CartState extended property (for online sales). Null or empty string means no filter.</param>
        /// <returns>Array of carts for this customer.</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Application, CommerceRoles.Employee, CommerceRoles.Customer)]
        public async Task<PagedResult<Cart>> SearchCustomerCarts(IEndpointContext ctx, long puid, string friendlyName, string cartState)
        {

            return (await ctx.ExecuteAsync<DataResponse<Cart[]>>(new SearchCustomerCartsRequest(puid, friendlyName, cartState)).ConfigureAwait(false)).Item.ToPagedResult();
        }

        [Authorization(CommerceRoles.Customer, CommerceRoles.Anonymous, CommerceRoles.Application)]
        public async Task<Cart> RemoveCartLines(IEndpointContext ctx, string cartId, string[] cartLineIds)
        {

            try
            {
                var request = new RemoveCartLinesRequest(cartId, cartLineIds);
                var response = await ctx.ExecuteAsync<SaveCartLinesResponse>(request).ConfigureAwait(false);
                return response.Cart;
            }
            catch (DataValidationException ex)
            {
                if (ex.ErrorResourceId == DataValidationErrors.Microsoft_Dynamics_Commerce_Runtime_ObjectNotFound.ToString())
                {
                    return (await ctx.ExecuteAsync<GetCartServiceResponse>(new GetCartServiceRequest(new CartSearchCriteria { CartId = cartId }, QueryResultSettings.FirstRecord)).ConfigureAwait(false))?.Carts?.FirstOrDefault();
                }

                throw;
            }
        }

        /// <summary>
        /// Search for cart by MUID and friendly name.
        /// </summary>
        /// <param name="muid">Anonymous Microsoft account identifier.</param>
        /// <param name="friendlyName">Filter on FriendlyName extended property (for online sales). Null or empty string means no filter.</param>
        /// <param name="cartState">Filter on CartState extended property (for online sales). Null or empty string means no filter.</param>
        /// <returns>Array of carts for this customer.</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Application, CommerceRoles.Employee, CommerceRoles.Customer)]
        public async Task<PagedResult<Cart>> SearchAnonymousCarts(IEndpointContext ctx, string muid, string friendlyName, string cartState)
        {
            return (await ctx.ExecuteAsync<DataResponse<Cart[]>>(new SearchAnonymousCartsRequest(muid, friendlyName, cartState)).ConfigureAwait(false)).Item.ToPagedResult();
        }

        /// <summary>
        /// Creates a copy of the cart.
        /// </summary>
        /// <param name="key">The entity key, which is cart identifier.</param>
        /// <param name="parameters">The dictionary of action parameter values.</param>
        /// <returns>The cart object.</returns>
        [Authorization(CommerceRoles.Application, CommerceRoles.Employee, CommerceRoles.Customer)]
        [HttpPost]
        public async Task<Cart> OnlineStoreCopy(IEndpointContext ctx, string cartId, int targetCartType)
        {
            ResponseHelper.NullCheck(cartId, nameof(cartId));
            ResponseHelper.NullCheck(targetCartType, nameof(targetCartType));
            var result = await ctx.ExecuteAsync<DataResponse<Cart>>(new OnlineStoreCopyRequest(cartId, (CartType)targetCartType)).ConfigureAwait(false);
            return result.Item;
        }

        /// <summary>
        /// Checkouts the sales cart.
        /// </summary>
        /// <param name="cartId">The entity key, which is cart identifier.</param>
        /// <param name="parameters">The action parameters.</param>
        /// <returns>The sales order object.</returns>
        [Authorization(CommerceRoles.Application, CommerceRoles.Employee, CommerceRoles.Customer)]
        [HttpPost]
        public async Task<SalesOrder> OnlineStoreCheckout(IEndpointContext ctx, string cartId, string receiptEmail, TokenizedPaymentCard tokenizedPaymentCard, string receiptNumberSequence, IEnumerable<CartTenderLine> cartTenderLines, long? cartVersion)
        {
            ResponseHelper.NullCheck(cartId, nameof(cartId));
            var response = await ctx.ExecuteAsync<DataResponse<SalesOrder>>(new OnlineStoreCheckoutRequest(cartId, receiptEmail, cartTenderLines, tokenizedPaymentCard, receiptNumberSequence, cartVersion)).ConfigureAwait(false);

            return response.Item;
        }
    }
}
