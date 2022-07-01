// <copyright file="SalesOrderController.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;
    using global::MSE.D365.CommerceRuntime.Extensions.OnlineSalesInvoice;
    using global::MSE.D365.Library.Chargeback;
    using global::MSE.D365.Library.OnlineOrder;
    using global::MSE.D365.Library.OnlineRefunds;
    using global::MSE.D365.Library.Tax;
    using Microsoft.Dynamics.Commerce.Runtime;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using Microsoft.Dynamics.Commerce.Runtime.Services.Messages;
    using Microsoft.MSE.D365.CommerceRuntime.Extensions;
    using Microsoft.MSE.D365.Library;

    /// <summary>
    /// Inheritance of SalesOrderController to extend its actions
    /// </summary>
    [ComVisible(false)]
    public class SalesOrderController : IController
    {

        private string validationMessage = string.Empty;

        /// <summary>
        /// Posts sales order in FnO.
        /// </summary>
        /// <returns>Void.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Application)]
        public async Task<bool> PostSalesOrder(IEndpointContext ctx, string SalesId)
        {
            ResponseHelper.NullCheck(SalesId, nameof(SalesId));
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new PostSalesOrderSalesRequest(SalesId)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Posts sales lines in FnO.
        /// </summary>
        /// <returns>Void.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Application)]
        public async Task<bool> PostSalesLines(IEndpointContext ctx, string salesId, IEnumerable<string> salesLineIds, bool? forceReinvoice)
        {
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new PostSalesLinesSalesRequest(salesId, salesLineIds, forceReinvoice ?? false)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Updates the SalesLine in FnO.
        /// </summary>
        /// <returns>The transaction id.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> UpdateSalesLineFromJson(IEndpointContext ctx, string updateSalesLineData)
        {
            ResponseHelper.NullCheck(updateSalesLineData, nameof(updateSalesLineData));
            var updateSalesLine = ResponseHelper.ValidateJsonParameter<OnlineSalesLineUpdateRequest>(updateSalesLineData, nameof(updateSalesLineData));
            ResponseHelper.NullCheck(updateSalesLine.TransactionId, nameof(updateSalesLineData) + "." + nameof(OnlineSalesLineUpdateRequest.TransactionId));
            if (updateSalesLine.LineNumber == 0.0m)
            {
                ResponseHelper.Fail($"LineNumber must not be zero");
            }

            return (await ctx.ExecuteAsync<DataResponse<bool>>(new UpdateSalesLineSalesRequest(updateSalesLine)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Updates the SalesLine in FnO.
        /// </summary>
        /// <returns>The transaction id.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> UpdateSalesLineFromRequest(IEndpointContext ctx, OnlineSalesLineUpdateRequest updateSalesLine)
        {
            ResponseHelper.NullCheck(updateSalesLine, nameof(updateSalesLine));
            ResponseHelper.NullCheck(updateSalesLine.TransactionId, nameof(updateSalesLine) + "." + nameof(OnlineSalesLineUpdateRequest.TransactionId));
            if (updateSalesLine.LineNumber == 0.0m)
            {
                ResponseHelper.Fail($"LineNumber must not be zero");
            }

            return (await ctx.ExecuteAsync<DataResponse<bool>>(new UpdateSalesLineSalesRequest(updateSalesLine)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Updates the SalesLine in FnO.
        /// </summary>
        /// <returns>The transaction id.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> UpdateSalesLinesFromRequest(IEndpointContext ctx, List<OnlineSalesLineUpdateRequest> updateSalesLines, string storageLocation)
        {
            ResponseHelper.NullCheck(updateSalesLines?.FirstOrDefault()?.TransactionId, $"You must supply at least one entry and it must have a TransactionId");

            if (updateSalesLines[0].LineNumber == 0.0m)
            {
                ResponseHelper.Fail($"LineNumber must not be zero");
            }

            updateSalesLines.ForEach(line =>
            {
                if (line.FulfillmentState != null && line.FulfillmentState.Equals("Fulfilled", StringComparison.InvariantCultureIgnoreCase) && !line.FulfilledDate.HasValue)
                {
                    line.FulfilledDate = DateTime.UtcNow;
                }
            });
            var storageLocation1 = StorageLocation.All;
            Enum.TryParse<StorageLocation>(storageLocation, out storageLocation1);

            var onlineSalesLinesUpdateRequest = new OnlineSalesLinesUpdateRequest
            {
                OnlineSalesLineUpdateRequestList = updateSalesLines,
                StorageLocation = storageLocation1,
            };

            return (await ctx.ExecuteAsync<DataResponse<bool>>(new UpdateSalesLinesSalesRequest(onlineSalesLinesUpdateRequest)).ConfigureAwait(false)).Item;
        }

        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public Task<bool> UpdateSalesLines(IEndpointContext ctx, string updateSalesLinesData, string storageLocation)
        {
            ResponseHelper.NullCheck(updateSalesLinesData, nameof(updateSalesLinesData));
            var updateSalesLines = ResponseHelper.ValidateJsonParameter<List<OnlineSalesLineUpdateRequest>>(updateSalesLinesData, nameof(updateSalesLinesData));
            return UpdateSalesLinesFromRequest(ctx, updateSalesLines, storageLocation);
        }


        /// <summary>
        /// Updates the SalesOrder in FnO.
        /// </summary>
        /// <returns>The transaction id.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> UpdateSalesOrder(IEndpointContext ctx, string salesOrderUpdateRequest)
        {
            var salesorderUpdate = ResponseHelper.ValidateJsonParameter<OnlineSalesOrderUpdateRequest>(salesOrderUpdateRequest, nameof(salesOrderUpdateRequest));
            ResponseHelper.NullCheck(salesorderUpdate?.TransactionId, nameof(salesOrderUpdateRequest) + "." + nameof(OnlineSalesOrderUpdateRequest.TransactionId));
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new UpdateSalesOrderSalesRequest(salesorderUpdate)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Updates the SalesOrder in FnO.
        /// </summary>
        /// <returns>The transaction id.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> UpdateSalesOrderFromRequest(IEndpointContext ctx, OnlineSalesOrderUpdateRequest salesOrderUpdateRequest)
        {
            ResponseHelper.NullCheck(salesOrderUpdateRequest?.TransactionId, nameof(salesOrderUpdateRequest) + "." + nameof(OnlineSalesOrderUpdateRequest.TransactionId));
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new UpdateSalesOrderSalesRequest(salesOrderUpdateRequest)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Searches for orders matching the given search criteria.
        /// This API is overridden to provide Application Authorization.
        /// </summary>
        /// <param name="queryOptions">The query options.</param>
        /// <returns>The collection of sales order.</returns>
        /// <remarks>
        /// Search result contains orders of type <see cref="TransactionType.CustomerOrder"/>, <see cref="TransactionType.PendingSalesOrder"/>, <see cref="TransactionType.AsyncCustomerOrder"/> and <see cref="TransactionType.AsyncCustomerQuote"/>
        /// </remarks>
        [Authorization(CommerceRoles.Customer, CommerceRoles.Employee, CommerceRoles.Application)]
        [HttpPost]
        public async Task<PagedResult<SalesOrder>> SearchOrders(IEndpointContext ctx, OrderSearchCriteria orderSearchCriteria, QueryResultSettings queryResultSettings)
        {
            return (await ctx.ExecuteAsync<SearchOrdersServiceResponse>(new SearchOrdersServiceRequest(orderSearchCriteria, queryResultSettings)).ConfigureAwait(false)).Orders;
        }

        /// <summary>
        /// Gets the sales invoice associated with the passed sales identifier.
        /// </summary>
        /// <returns>The sales invoice object.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Application)]
        public async Task<PagedResult<SalesInvoice>> GetInvoicesBySalesId(IEndpointContext ctx, string salesId)
        {
            ResponseHelper.NullCheck(salesId, nameof(salesId));
            return (await ctx.ExecuteAsync<GetSalesInvoicesBySalesIdsResponse>(new GetSalesInvoicesBySalesIdsRequest(salesId)).ConfigureAwait(false)).SalesInvoices?.ToPagedResult();
        }

        /// <summary>
        /// Gets the sales invoice associated with the passed sales order identifiers.
        /// </summary>
        /// <param name="salesIds"> list of Sales IDs passed comma separated.</param>
        /// <returns>PageResult<SalesInvoice>.</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Application)]
        public async Task<PagedResult<SalesInvoice>> GetInvoicesBySalesIds(IEndpointContext ctx, string salesIds)
        {
            ResponseHelper.NullCheck(salesIds, nameof(salesIds));
            return (await ctx.ExecuteAsync<GetSalesInvoicesBySalesIdsResponse>(new GetSalesInvoicesBySalesIdsRequest(salesIds)).ConfigureAwait(false)).SalesInvoices?.ToPagedResult();
        }

        /// <summary>
        /// Gets the list of invoiced sales lines by sales order identifiers.
        /// </summary>
        /// <param name="queryOptions">The query options object.</param>
        /// <returns>The list of invoiced sales lines.</returns>
        [Authorization(CommerceRoles.Customer, CommerceRoles.Employee, CommerceRoles.Application)]
        [HttpPost]
        public async Task<PagedResult<SalesLine>> GetInvoicedSalesLinesBySalesIds(IEndpointContext ctx, IEnumerable<string> salesIds, QueryResultSettings queryResultSettings)
        {
            return (await ctx.ExecuteAsync<DataResponse<PagedResult<SalesLine>>>(new GetInvoicedSalesLinesBySalesIdsSalesRequest(salesIds) { QueryResultSettings = queryResultSettings }).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Gets a <see cref="SalesOrder"/> with all of it's details.
        /// </summary>
        /// <param name="salesId">The sales identifier of the order.</param>
        /// <returns>The sales order.</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Customer, CommerceRoles.Application)]
        public async Task<SalesOrder> GetSalesOrderDetailsBySalesId(IEndpointContext ctx, string salesId)
        {
            ResponseHelper.NullCheck(salesId, nameof(salesId));
            return (await ctx.ExecuteAsync<DataResponse<SalesOrder>>(new GetSalesOrderDetailsBySalesIdSalesRequest(salesId)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Get order details based on ReservationId
        /// </summary>
        /// <param name="reservationId">Reservation Id</param>
        /// <returns>Paged Result of SalesOrders</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<PagedResult<SalesOrder>> GetSalesOrderDetailsByReservationId(IEndpointContext ctx, string reservationId)
        {
            ResponseHelper.NullCheck(reservationId, nameof(reservationId));
            var reservationIdFilterValue = new SearchFilterValue
            {
                Value = new CommercePropertyValue() { StringValue = reservationId },
            };

            var reservationIdFilter = new SearchFilter
            {
                Key = "ReservationId",
                SearchValues = { reservationIdFilterValue },
            };

            var orderSearchCriteria = new OrderSearchCriteria() { CustomFilters = { reservationIdFilter } };
            var request = new SearchOrdersServiceRequest(orderSearchCriteria, QueryResultSettings.AllRecords);
            return (await ctx.ExecuteAsync<SearchOrdersServiceResponse>(request).ConfigureAwait(false))?.Orders;
        }

        /// <summary>
        /// Sends emails to user from Send Email functionality from Show Journal page.
        /// </summary>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<bool> SendReceipt(IEndpointContext ctx, SearchReceiptCriteria searchCriteria, IEnumerable<ElectronicAddress> recipientAddresses)
        {
            ResponseHelper.NullCheck(searchCriteria, nameof(searchCriteria));
            ResponseHelper.NullCheck(recipientAddresses?.FirstOrDefault(), nameof(recipientAddresses));
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new SendReceiptSalesRequest(searchCriteria, recipientAddresses)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Get online orders.
        /// </summary>
        /// <returns>Sales order searched.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application, CommerceRoles.Employee)]
        public async Task<PagedResult<SalesOrder>> GetOnlineOrders(IEndpointContext ctx)
        {
            return (await ctx.ExecuteAsync<DataResponse<List<SalesOrder>>>(new GetOnlineOrdersSalesRequest()).ConfigureAwait(false)).Item.ToPagedResult();
        }

        /// <summary>
        /// Gets a <see cref="SalesOrder"/> by risk id
        /// </summary>
        /// <param name="riskId">The risk id which we get from the review decision.</param>
        /// <returns>The sales order.</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Application)]
        public async Task<SalesOrder> GetSalesOrderByRiskId(IEndpointContext ctx, string riskId)
        {
            SalesOrder salesOrderResponse = null;
            var riskIdTransactionIdMapRequest = new RiskIdentifierMapRequest(riskId);
            var riskIdTransactionIdMapResponse = await ctx.ExecuteAsync<RiskIdentifierMapResponse>(riskIdTransactionIdMapRequest).ConfigureAwait(false);
            var transactionId = riskIdTransactionIdMapResponse?.TransactionId;
            if (!string.IsNullOrWhiteSpace(transactionId))
            {
                var detailsRequest = new GetSalesOrderDetailsByTransactionIdServiceRequest(transactionId, SearchLocation.Remote);
                var detailsResponse = await ctx.ExecuteAsync<GetSalesOrderDetailsServiceResponse>(detailsRequest).ConfigureAwait(false);
                if (detailsResponse != null && detailsResponse.SalesOrder != null)
                {
                    salesOrderResponse = detailsResponse.SalesOrder;
                }
            }

            return salesOrderResponse;
        }

        /// <summary>
        /// Gets a <see cref="SalesOrder"/> with all of it's details.
        /// </summary>
        /// <param name="transactionId">The transaction identifier of the order.</param>
        /// <param name="searchLocationValue">The location where to get the order.</param>
        /// <returns>The sales order.</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Customer, CommerceRoles.Anonymous, CommerceRoles.Application)]
        public async Task<SalesOrder> GetSalesOrderDetailsByTransactionId(IEndpointContext ctx, string transactionId, SearchLocation searchLocationValue)
        {
            return (await ctx.ExecuteAsync<DataResponse<SalesOrder>>(new GetSalesOrderDetailsByTransactionIdSalesRequest(transactionId, searchLocationValue)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Gets list of <see cref="SalesOrder"/> by payment instrument id.
        /// </summary>
        /// <param name="puid">User Puid</param>
        /// <param name="paymentInstrumentId">Payment instrument id.</param>
        /// <returns>List of Sales order details.</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Application)]
        public async Task<PagedResult<SalesOrder>> GetSalesOrderDetailsByPaymentInstrumentId(IEndpointContext ctx, long puid, string paymentInstrumentId)
        {
            ResponseHelper.NullCheck(puid, nameof(puid));
            ResponseHelper.NullCheck(paymentInstrumentId, nameof(paymentInstrumentId));

            var ordersFilteringRequest = new OrdersFilteringRequest(puid, paymentInstrumentId);
            var ordersFilteringResponse = await ctx.ExecuteAsync<OrdersFilteringResponse>(ordersFilteringRequest).ConfigureAwait(false);
            var salesOrders = new List<SalesOrder>();
            foreach (var salesOrderDetail in ordersFilteringResponse.SalesOrderDetails)
            {
                var salesOrder = new SalesOrder()
                {
                    Id = salesOrderDetail.Id,
                };

                foreach (var salesLineDetail in salesOrderDetail.SalesLineDetails)
                {
                    var salesLine = new SalesLine() { LineNumber = decimal.Parse(salesLineDetail.Id) };
                    salesLine.ExtensionProperties.Add(new CommerceProperty(SalesLineExtensionProperty.BillingStateProperty, salesLineDetail.BillingState));
                    salesLine.ExtensionProperties.Add(new CommerceProperty(SalesLineExtensionProperty.FulfillmentStateProperty, salesLineDetail.FulfillmentState));
                    salesOrder.SalesLines.Add(salesLine);
                }

                salesOrders.Add(salesOrder);
            }

            return salesOrders.ToPagedResult();
        }

        /// <summary>
        /// Creates a picking list for selected lines on sales order.
        /// Overriden in this class to expose for Application access.
        /// </summary>
        /// <returns>The picking list id created.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Application)]
        public async Task<string> CreatePickingListForItems(IEndpointContext ctx, string salesId, IEnumerable<PickAndPackSalesLineParameter> pickAndPackSalesLineParameters)
        {
            var request = new PickAndPackOrderRequest(salesId, pickAndPackSalesLineParameters, createPickingList: true, createPackingSlip: false);
            var response = await ctx.ExecuteAsync<PickAndPackOrderResponse>(request).ConfigureAwait(false);
            return response.PickingListId;
        }

        /// <summary>
        /// Trigger re-authorization of payment for whole request in FnO.
        /// </summary>
        /// <returns>True/false depending on success.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> ReauthBySalesId(IEndpointContext ctx, string salesId, bool? newAuth, bool? suppressEmail)
        {
            ResponseHelper.NullCheck(salesId, nameof(salesId));
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new ReauthBySalesIdSalesRequest(salesId, newAuth ?? false, suppressEmail ?? false)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Trigger refund of sales order in FnO.
        /// </summary>
        /// <returns>True/false depending on success.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> RefundSalesLines(IEndpointContext ctx, long puid, string trackingId, string salesId, IEnumerable<RefundSalesLineDetail> refundSalesLinesDetail)
        {
            ResponseHelper.NullCheck(trackingId, nameof(trackingId));
            ResponseHelper.NullCheck(salesId, nameof(salesId));
            ResponseHelper.NullCheck(refundSalesLinesDetail, nameof(refundSalesLinesDetail));
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new RefundSalesLinesSalesRequest(puid, trackingId, salesId, refundSalesLinesDetail)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Trigger tax refund of sales order in FnO.
        /// </summary>
        /// <param name="parameters">Sales id.</param>
        /// <returns>True/false depending on success.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> TaxOnlyRefund(IEndpointContext ctx, long puid, string trackingId, string salesId)
        {
            // puid and trackingId are not used. They exist for backwards-compatibility.
            var loadSalesOrderRequest = new GetSalesOrderDetailsBySalesIdServiceRequest(salesId, SearchLocation.Remote);
            var loadSalesOrderRequestResponse = await ctx.ExecuteAsync<GetSalesOrderDetailsServiceResponse>(loadSalesOrderRequest).ConfigureAwait(false);
            SalesTransaction salesOrder = loadSalesOrderRequestResponse.SalesOrder;

            // TODO check if PUID on order matches incoming PUID
            if (salesOrder?.SalesId?.Equals(salesId) != true)
            {
                throw new DataValidationException(
                    DataValidationErrors.Microsoft_Dynamics_Commerce_Runtime_InvalidRequest,
                    $"SalesId {salesId} in the TaxOnlyRefund does not exist");
            }

            var taxOnlyRefundRequest = new TaxOnlyRefundRequest(salesId);
            var taxOnlyRefundResponse = await ctx.ExecuteAsync<TaxOnlyRefundResponse>(taxOnlyRefundRequest).ConfigureAwait(false);
            return true;
        }

        /// <summary>Creates a packing slip.
        /// Overriden in this class to expose for Application access.
        /// </summary>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Application)]
        public async Task<bool> CreatePackingSlip(IEndpointContext ctx, string salesId)
        {
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new CreatePackingSlipSalesRequest(salesId)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Cancel SalesLines.
        /// </summary>
        /// <returns><void>A <see cref="Task"/> representing the asynchronous operation.</void></returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> CancelSalesLines(IEndpointContext ctx, long puid, string trackingId, string transactionId, IEnumerable<CancelSalesLineDetail> cancelSalesLinesDetail)
        {
            ResponseHelper.NullCheck(transactionId, nameof(transactionId));
            ResponseHelper.NullCheck(cancelSalesLinesDetail, nameof(cancelSalesLinesDetail));
            ResponseHelper.NullCheck(trackingId, nameof(trackingId));

            var now = DateTime.UtcNow;
            var lineDetails = cancelSalesLinesDetail.Select(lineDetail => new SalesLineDetailRequest { LineNum = lineDetail.LineNum, ReasonCode = lineDetail.ReasonCode, CanceledDate = now }).ToArray();

            return (await ctx.ExecuteAsync<DataResponse<bool>>(new CancelSalesLinesSalesRequest(puid, transactionId, lineDetails, trackingId)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Gets Online Orders List for return.
        /// </summary>
        /// <returns>Sales Order List.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Customer, CommerceRoles.Anonymous, CommerceRoles.Application)]
        public async Task<PagedResult<SalesOrder>> SearchOnlineOrderForReturnInStore(IEndpointContext ctx, string shortOrderId, string customerEmailAddress)
        {
            ResponseHelper.NullCheck(customerEmailAddress, nameof(customerEmailAddress));
            return (await ctx.ExecuteAsync<DataResponse<PagedResult<SalesOrder>>>(new SearchOnlineOrderForReturnInStoreSalesRequest(shortOrderId, customerEmailAddress)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Trigger chargeback of invoice in FnO.
        /// </summary>
        /// <returns>Created sales order Id, True/false depending on success., detailed message.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<ChargebackResponse> Chargeback(IEndpointContext ctx, string invoiceId, string chargebackReferenceId, decimal chargebackAmount)
        {
            ResponseHelper.NullCheck(invoiceId, nameof(invoiceId));
            ResponseHelper.NullCheck(chargebackReferenceId, nameof(chargebackReferenceId));
            if (chargebackAmount == 0)
            {
                ResponseHelper.Fail("Chargeback amount must be non-zero");
            }
            string error = null;
            try
            {
                var response = (await ctx.ExecuteAsync<DataResponse<ChargebackResponse>>(new ChargebackSalesRequest(invoiceId, chargebackReferenceId, chargebackAmount)).ConfigureAwait(false)).Item;

                if (response.Successful)
                {
                    return response;
                }

                error = response.Message;
            }
            catch (Exception ex)
            {
                error = string.Concat(ex.Message, ex?.InnerException?.Message);
            }

            throw ResponseHelper.Fail(error);
        }

        /// <summary>
        /// Update FnO with tax invoice ID for the given transaction + quantity group id
        /// </summary>
        /// <returns>Detais message, True/false depending on success.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<TaxInvoiceResponse> UpdateTaxInvoice(IEndpointContext ctx, string transactionId, string salesId, string taxInvoiceId, bool? isRefund, string quantityGroupId)
        {
            ResponseHelper.NullCheck(transactionId, nameof(transactionId));
            ResponseHelper.NullCheck(salesId, nameof(salesId));
            ResponseHelper.NullCheck(taxInvoiceId, nameof(taxInvoiceId));
            ResponseHelper.NullCheck(quantityGroupId, nameof(quantityGroupId));
            ResponseHelper.NullCheck((object)isRefund, nameof(isRefund));

            string error = null;
            try
            {

                var response = await ctx.ExecuteAsync<TaxInvoiceResponse>(new TaxInvoiceRequest(transactionId, salesId, taxInvoiceId, isRefund.GetValueOrDefault(), quantityGroupId)).ConfigureAwait(false);

                if (response.Successful)
                {
                    return response;
                }

                error = response.Message;
            }
            catch (Exception ex)
            {
                error = string.Concat(ex.Message, ex?.InnerException?.Message);
            }

            throw ResponseHelper.Fail(error);
        }


        /// <summary>
        /// Send Update PI Email for given sales order.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>true or false.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> SendUpdatePIEmail(IEndpointContext ctx, long puid, string transactionId)
        {
            ResponseHelper.NullCheck(transactionId, nameof(transactionId));
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new SendUpdatePIEmailSalesRequest(puid, transactionId)).ConfigureAwait(false)).Item;
        }
    }
}
