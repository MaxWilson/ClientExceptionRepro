// <copyright file="ActionsController.cs" company="Microsoft">
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
    using global::MSE.D365.Library.CartExport;
    using global::MSE.D365.Library.HealthCheck;
    using global::MSE.D365.Library.OnlineOrder;
    using global::MSE.D365.Library.PaymentMethod;
    using global::MSE.D365.Library.PaymentMethods;
    using global::MSE.D365.Library.StoreOpenClose;
    using global::MSE.D365.Library.Telemetry;
    using Microsoft.Dynamics.Commerce.Runtime;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.DataServices.Messages;
    using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using Microsoft.Dynamics.Commerce.Runtime.Services.Messages;
    using Microsoft.MSE.D365.Library;
    using Microsoft.MSE.D365.Library.CRMOrder;
    using MSE.D365.RetailServer.Extensions.OData;
    using Newtonsoft.Json;

    /// <summary>
    /// This class is a place to put actions that aren't really associated with any collection.
    /// </summary>
    [ComVisible(false)]
    public class ActionsController : IController
    {
        private string validationMessage = string.Empty;

        /// <summary>
        /// Authorize Employee with the username and password hash.
        /// </summary>
        /// <param name="parameters">StaffId and PasswordData.</param>
        /// <returns>boolean.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device, CommerceRoles.Application)]
        public async Task<bool> Authenticate(IEndpointContext ctx, string staffId, string passwordData)
        {
            ResponseHelper.NullCheck(staffId, nameof(staffId));
            ResponseHelper.NullCheck(passwordData, nameof(passwordData));
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new AuthenticateRequest(staffId, passwordData)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Entry point for runner request from POS.
        /// </summary>
        /// <param name="ctx">Endpoint context for accessing CRT.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<RunnerRequest> RequestRunner(IEndpointContext ctx, RunnerRequest runnerRequest)
        {
            ResponseHelper.NullCheck(runnerRequest, nameof(runnerRequest));
            return (await ctx.ExecuteAsync<DataResponse<RunnerRequest>>(new RequestRunnerICERequest(runnerRequest)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Entry point for cancel runner request from POS.
        /// </summary>
        /// <param name="ctx">Endpoint context for accessing CRT.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<RunnerRequest> CancelRunnerRequest(IEndpointContext ctx, string id, string employeeAlias)
        {
            ResponseHelper.NullCheck(id, nameof(id));
            ResponseHelper.NullCheck(employeeAlias, nameof(employeeAlias));
            return (await ctx.ExecuteAsync<DataResponse<RunnerRequest>>(new CancelRunnerICERequest(id, employeeAlias)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Entry point for complete runner request from POS.
        /// </summary>
        /// <param name="ctx">Endpoint context for accessing CRT.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<RunnerRequest> CompleteRunnerRequest(IEndpointContext ctx, string id, string employeeAlias)
        {
            ResponseHelper.NullCheck(id, nameof(id));
            ResponseHelper.NullCheck(employeeAlias, nameof(employeeAlias));
            return (await ctx.ExecuteAsync<DataResponse<RunnerRequest>>(new CompleteRunnerICERequest(id, employeeAlias)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Entry point for refresh runner request from POS
        /// </summary>
        /// <param name="parameters">oData parameters</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<RunnerRequest> RefreshRunnerRequest(IEndpointContext ctx, string id)
        {
            ResponseHelper.NullCheck(id, nameof(id));
            return (await ctx.ExecuteAsync<DataResponse<RunnerRequest>>(new RefreshRunnerICERequest(id)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Feed logging data collected in JavaScript to AppInsights.
        /// </summary>
        /// <param name="parameters">LogList.</param>
        /// <returns>true.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<bool> LogDataBulk(IEndpointContext ctx, LogList LogList)
        {
            ResponseHelper.NullCheck(LogList, nameof(LogList));
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new LogDataBulkRequest(LogList)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Allow POS to query for how much money to expect in given store.
        /// </summary>
        /// <param name="parameters">shiftTerminalId: string, shiftId: string.</param>
        /// <returns>Expected dollars, as a double.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<ExpectedCashTotalBalance> GetExpectedCashTotalBalance(IEndpointContext ctx)
        {
            return (await ctx.ExecuteAsync<DataResponse<ExpectedCashTotalBalance>>(new GetExpectedCashTotalBalanceRequest()).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// At end of day, set expectations for how much money the store should start off with tomorrow.
        /// </summary>
        /// <param name="parameters">shiftTerminalId: string, shiftId: string.</param>
        /// <returns>true.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<bool> DeclareEndOfDayBalance(IEndpointContext ctx, decimal? balance)
        {
            ResponseHelper.NullCheck(balance, nameof(balance));
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new DeclareEndOfDayBalanceActionRequest(balance ?? 0M)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Get the next number sequence for CRM integration.
        /// </summary>
        /// <param name="parameters">The parameter.</param>
        /// <param name="options">The options.</param>
        /// <returns>The number sequence result.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee)]
        public virtual async Task<PagedResult<NumberSequenceSeedData>> MSEGetLatestNumberSequence(IEndpointContext ctx, QueryResultSettings queryResultSettings)
        {
            GetNumberSequenceRequest request = new GetNumberSequenceRequest { QueryResultSettings = queryResultSettings };
            request.SetProperty(CRMOrderConstant.ISREQUESTFROMCRM, true);

            return (await ctx.ExecuteAsync<GetNumberSequenceResponse>(request).ConfigureAwait(false)).NumberSequence;
        }

        /// <summary>
        /// Perform system health check for this terminal's store.
        /// </summary>
        /// <param name="parameters">No oData parameters.</param>
        /// <returns>true.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<HealthCheckResults> SystemHealthCheck(IEndpointContext ctx)
        {
            return (await ctx.ExecuteAsync<DataResponse<HealthCheckResults>>(new SystemHealthCheckRequest()).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Returns list of payment methods with property for choosing whether to display payment method or not.
        /// </summary>
        /// <param name="ctx">Endpoint context for accessing CRT.</param>
        /// <returns>List of payment methods with property for choosing whether to display payment method or not.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Customer, CommerceRoles.Device, CommerceRoles.Employee)]
        public async Task<GetPaymentMethodsCustomListResponse> GetPaymentMethodsCustomProperty(IEndpointContext ctx)
        {
            IEnumerable<GetPaymentMethodsCustomResponse> response =
                (await ctx.ExecuteAsync<EntityDataServiceResponse<GetPaymentMethodsCustomResponse>>(new GetPaymentMethodsCustomRequest()).ConfigureAwait(false)).PagedEntityCollection;

            GetPaymentMethodsCustomListResponse getPaymentMethodsCustomListResponse = new GetPaymentMethodsCustomListResponse();
            getPaymentMethodsCustomListResponse.Id = default(Guid).ToString();
            getPaymentMethodsCustomListResponse.GetPaymentMethodsCustomPropertiesListResponse = response;

            return getPaymentMethodsCustomListResponse;
        }

        /// <summary>
        /// Calculates tax for given sales order.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The identifier of the sales order created.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<string> CalculateTax(IEndpointContext ctx, string salesTransaction)
        {
            // trying to send or return an actual SalesTransaction object causes errors with proxy generation
            // a la "cannot declare SalesTransaction as a Complex Type because it is already an entity type"
            // so instead we send it in JSON format
            SalesTransaction salesTransaction1 = ResponseHelper.ValidateJsonParameter<SalesTransaction>(salesTransaction, nameof(salesTransaction));

            return JsonConvert.SerializeObject((await ctx.ExecuteAsync<DataResponse<SalesTransaction>>(new CalculateTaxRequest(salesTransaction1)).ConfigureAwait(false)).Item);
        }

        /// <summary>
        /// Get all of a customer's carts that haven't already been Accepted by MST. (POBO scenario.)
        /// </summary>
        /// <param name="puid">Customer account number</param>
        /// <returns>Array of carts for this customer.</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Application)]
        public async Task<PagedResult<Cart>> GetCustomerCarts(IEndpointContext ctx, long puid)
        {
            ResponseHelper.NullCheck(puid, nameof(puid));
            return (await ctx.ExecuteAsync<DataResponse<Cart[]>>(new GetPOBOCustomerCartsRequest(puid)).ConfigureAwait(false)).Item.ToPagedResult();
        }

        /// <summary>
        /// Get a cart that hasn't already been Accepted by MST. (POBO scenario.)
        /// </summary>
        /// <param name="cartId">Cart ID.</param>
        /// <returns>200/OK with Cart if successful, else 404/Not Found.</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Application)]
        public async Task<Cart> GetCart(IEndpointContext ctx, string cartId)
        {
            ResponseHelper.NullCheck(cartId, nameof(cartId));
            return (await ctx.ExecuteAsync<DataResponse<Cart>>(new GetPOBOCartRequest(cartId)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Get a cart that hasn't already been Accepted by MST. (POBO scenario.)
        /// </summary>
        /// <param name="friendlyId">Friendly ID.</param>
        /// <returns>200/OK with Cart if successful, else 404/Not Found.</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Application)]
        public async Task<Cart> GetCartByFriendlyId(IEndpointContext ctx, string friendlyId)
        {
            ResponseHelper.NullCheck(friendlyId, nameof(friendlyId));
            return (await ctx.ExecuteAsync<DataResponse<Cart[]>>(new GetPOBOCartByFriendlyIdRequest(friendlyId)).ConfigureAwait(false)).Item.FirstOrDefault();
        }

        /// <summary>
        /// Mark a given cart as already processed, should no longer show up in MST lists. (POBO scenario.)
        /// </summary>
        /// <param name="parameters">parameters with string: cartId.</param>
        /// <returns>200/OK if successful, else 400/BadRequest.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<string> AcceptCart(IEndpointContext ctx, string cartId)
        {
            ResponseHelper.NullCheck(cartId, nameof(cartId));
            return (await ctx.ExecuteAsync<DataResponse<string>>(new AcceptPOBOCartRequest(cartId)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Updates the Manual Review in FnO.
        /// </summary>
        /// /// <param name="parameters">
        /// Takes <c>ODataActionParameters</c>.
        /// </param>
        /// <returns>Success.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> UpdateManualReview(IEndpointContext ctx, string riskId, string decision, string reason)
        {
            ResponseHelper.NullCheck(riskId, nameof(riskId));
            ResponseHelper.NullCheck(decision, nameof(decision));
            ResponseHelper.NullCheck(reason, nameof(reason)); // reason is not used, but maybe it exists for logging purposes?
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new UpdateManualReviewActionRequest(riskId, decision)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Updates the Manual Review decision in FnO.
        /// </summary>
        /// /// <param name="parameters">
        /// Takes <c>ODataActionParameters</c>.
        /// </param>
        /// <returns>OnlineSalesUpdateResponse</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> UpdateManualReviewBySalesId(IEndpointContext ctx, string salesId, string decision, string reason)
        {
            ResponseHelper.NullCheck(salesId, nameof(salesId));
            ResponseHelper.NullCheck(decision, nameof(decision));
            ResponseHelper.NullCheck(reason, nameof(reason)); // reason is not used, but maybe it exists for logging purposes?
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new UpdateManualReviewBySalesIdRequest(salesId, decision)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Updates the CreditCardAuthTrans record in FnO.
        /// </summary>
        /// /// <param name="parameters">
        /// Takes <c>ODataActionParameters</c>.
        /// </param>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> UpdateCCAuthTrans(
                                                    IEndpointContext ctx,
                                                    long recId, bool isVoided, bool isExpired, string invoiceId, string trackingId, DateTimeOffset approvedDate, int processorStatus,
                                                    decimal? approvalAmount, string paymentType, string testScenarios, long cardResultRecId, string authApprovalCodeOverride, decimal captureAmountOverride,
                                                    decimal refundAmountOverride, long salesTransRecId, long salesTransCCRecId, long salesTransRefundCCRecId,
                                                    int salesTransRefundType, decimal salesTransRefundAmount, int? transactionStatus, int? dunningStatus, DateTimeOffset? dunningStartDate,
                                                    bool isRefundable, long transactionRecId, long puid, string jarvisCid, string jarvisProfileId)
        {
            decimal approvalAmount1 = approvalAmount ?? -1;
            var dunningStartDate1 = dunningStartDate ?? new DateTimeOffset(1900, 1, 1, 0, 0, 0, TimeSpan.Zero);
            int dunningStatus1 = dunningStatus ?? -1;
            int transactionStatus1 = transactionStatus ?? -1;
            paymentType = paymentType ?? string.Empty;
            var request = new UpdateCCAuthTransActionRequest(
                recId,
                isVoided,
                isExpired,
                invoiceId,
                trackingId,
                approvedDate,
                processorStatus,
                approvalAmount1,
                paymentType,
                testScenarios,
                cardResultRecId,
                authApprovalCodeOverride,
                captureAmountOverride,
                refundAmountOverride,
                salesTransRecId,
                salesTransCCRecId,
                salesTransRefundCCRecId,
                salesTransRefundType,
                salesTransRefundAmount,
                transactionStatus1,
                dunningStatus1,
                dunningStartDate1,
                isRefundable,
                transactionRecId,
                puid,
                jarvisCid,
                jarvisProfileId);

            return (await ctx.ExecuteAsync<DataResponse<bool>>(request).ConfigureAwait(false)).Item;
        }


        /// <summary>
        /// Create the CreditCardAuthTrans record in FnO.
        /// </summary>
        /// /// <param name="parameters">
        /// Takes <c>ODataActionParameters</c>.
        /// </param>
        /// <returns><bool>A <see cref="Task"/> return success or failure.</bool></returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> CreateCCATRecord(IEndpointContext ctx, string salesId, string invoiceId, string merchantReferenceNumber, string trackingId)
        {
            var request = new CreateCCATRecordActionRequest(salesId, invoiceId, merchantReferenceNumber, trackingId);
            return (await ctx.ExecuteAsync<DataResponse<bool>>(request).ConfigureAwait(false)).Item;
        }

        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> UpdateSalesLine(IEndpointContext ctx, string salesId, string lineNum, int? dunningStatus, int? dunningBusinessEventStatus, DateTimeOffset? dunningStartDate, decimal? lineAmount)
        {
            var request = new UpdateSalesLineRequest()
            {
                SalesId = salesId,
                LineNum = lineNum,
                DunningStartDate = dunningStartDate ?? new DateTimeOffset(1900, 1, 1, 0, 0, 0, TimeSpan.Zero),
                DunningStatus = dunningStatus ?? -1,
                DunningBusinessEventStatus = dunningBusinessEventStatus ?? -1,
                LineAmount = lineAmount ?? -1,
            };
            return (await ctx.ExecuteAsync<DataResponse<bool>>(request).ConfigureAwait(false)).Item;
        }


        /// <summary>
        /// Updates Sales Line in FnO.
        /// </summary>
        /// /// <param name="parameters">
        /// Takes <c>ODataActionParameters</c>.
        /// </param>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> UpdateSalesLineDunningStatus(IEndpointContext ctx, string salesId, string lineNum, int? dunningStatus, int? dunningBusinessEventStatus, DateTimeOffset? dunningStartDate, decimal? lineAmount)
        {
            var dunningStartDate1 = dunningStartDate ?? new DateTimeOffset(1900, 1, 1, 0, 0, 0, TimeSpan.Zero);
            int dunningStatus1 = dunningStatus ?? -1;
            int dunningBusinessEventStatus1 = dunningBusinessEventStatus ?? - 1;

            return (await ctx.ExecuteAsync<DataResponse<bool>>(new UpdateSalesLineActionRequest(salesId, lineNum, dunningStartDate1, dunningStatus1, dunningBusinessEventStatus1, lineAmount ?? -1)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Get table records in Retail server DB or from HQ DB.
        /// </summary>
        /// /// <param name="parameters">
        /// Takes <c>ODataActionParameters</c>.
        /// </param>
        /// <returns>Table records</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<string> GetTableRecords(IEndpointContext ctx, string tableName, string storageLocation, string filterBy, string filterValue, int? top, int? skip, string orderBy)
        {
            ResponseHelper.NullCheck(tableName, nameof(tableName));
            Enum.TryParse<StorageLocation>(storageLocation, out var storageLocation1);
            ResponseHelper.NullCheck(filterBy, nameof(filterBy));
            ResponseHelper.NullCheck(filterValue, nameof(filterValue));
            int top1 = top ?? 100;
            int skip1 = skip ?? 0;

            return (await ctx.ExecuteAsync<DataResponse<string>>(new GetTableRecordsActionRequest(tableName, storageLocation1, filterBy, filterValue, top1, skip1, orderBy)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Updates Sales records record in FnO to fix order.
        /// </summary>
        /// /// <param name="parameters">
        /// Takes <c>ODataActionParameters</c>.
        /// </param>
        /// <returns>Update Succeed or Failed.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> UpdateSalesRecords(IEndpointContext ctx, DateTimeOffset orderStartDate, DateTimeOffset orderEndDate, bool isManualReviewUpdate, bool isInvoicingRequired,
                                        bool isBillingStateUpdateRequired, bool iseTagUpdate, string addressID, bool isCancelSalesRequired, bool approveManualReview, string salesId, bool updateRefundedTotalAmount)
        {

            return (await ctx.ExecuteAsync<DataResponse<bool>>(new UpdateSalesRecordsRequest(orderStartDate, orderEndDate, isManualReviewUpdate, isInvoicingRequired, isBillingStateUpdateRequired, iseTagUpdate, addressID, isCancelSalesRequired, approveManualReview, salesId, updateRefundedTotalAmount)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        ///  Overrides the base class GetAffiliations to allow it to be called with S2S auth.
        /// </summary>
        /// <param name="queryOptions">OData query options.</param>
        /// <returns>List of affiliations.</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Application)]
        public async Task<PagedResult<Affiliation>> GetAffiliations_AppAccess(IEndpointContext ctx)
        {
            return (await ctx.ExecuteAsync<DataResponse<Affiliation[]>>(new GetAffiliationsRequest()).ConfigureAwait(false)).Item.ToPagedResult();
        }

        /// <summary>
        /// Cart Search based on last modifiedDatetime.
        /// </summary>
        /// <param name="lastModifiedDateTimeFrom">LastModifiedDateTimeFrom.</param>
        /// <returns>Array of carts for this customer.</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Application)]
        public async Task<AbandonedCartResponse> CartSearch(IEndpointContext ctx, DateTimeOffset? lastModifiedDateTimeFrom, bool IsMEOTemplate, QueryResultSettings queryResultSettings)
        {
            GetCartRequest getCartRequest = null;
            GetCartResponse getCartResponse = null;
            List<Cart> carts = new List<Cart>();

            PagedResult<Cart> cartResult;

            CartSearchCriteria cartSearchCriteria = new CartSearchCriteria
            {
                SuspendedOnly = false,
                CartTypeValue = (int)CartType.Shopping,
                IncludeAnonymous = false,
                LastModifiedDateTimeFrom = lastModifiedDateTimeFrom,
            };

            do
            {
                getCartRequest = new GetCartRequest(cartSearchCriteria, queryResultSettings);
                getCartResponse = await ctx.ExecuteAsync<GetCartResponse>(getCartRequest).ConfigureAwait(false);
                cartResult = getCartResponse?.Carts;
                carts.AddRange(cartResult.Results);
                queryResultSettings.Paging.Skip = carts.Count();
            }
            while (cartResult.Count() == (queryResultSettings?.Paging?.Top ?? 100));

            if (carts != null)
            {
                var abandonedCartResponse = (await ctx.ExecuteAsync<DataResponse<AbandonedCartResponse>>(new GetAbandonedCartDetailsRequest(carts, lastModifiedDateTimeFrom, IsMEOTemplate, getCartRequest) { QueryResultSettings = queryResultSettings }).ConfigureAwait(false)).Item;
                if (abandonedCartResponse.AbandonedCartResults.Any() || abandonedCartResponse.CartSearchResults.Any())
                {
                    return abandonedCartResponse;
                }

                throw ResponseHelper.Fail("Not found");
            }

            throw ResponseHelper.Fail("Not found");
        }

        /// <summary>
        /// Gets all online payment trackings
        /// </summary>
        /// <param name="parameters">PaymentStatus</param>
        /// <returns>Success or error message</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<GetOnlinePaymentTrackingResponse> GetAllOnlinePaymentTrackings(IEndpointContext ctx, int paymentStatus)
        {
            var request = new GetOnlinePaymentTrackingRequest(paymentStatus);
            return await ctx.ExecuteAsync<GetOnlinePaymentTrackingResponse>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all online payment trackings
        /// </summary>
        /// <param name="parameters">PaymentStatus</param>
        /// <returns>Success or error message</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<VoidOnlinePaymentTrackingResponse> VoidOnlinePaymentTracking(IEndpointContext ctx, string trackingId)
        {
            ResponseHelper.NullCheck(trackingId, nameof(trackingId));
            var request = new VoidOnlinePaymentTrackingRequest(trackingId);
            var response = await ctx.ExecuteAsync<VoidOnlinePaymentTrackingResponse>(request).ConfigureAwait(false);

            return response;
        }

        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> UpdateCreditCardAuthTransBySalesId(IEndpointContext ctx, bool isExpired, string salesId, int approvalType)
        {
            ResponseHelper.NullCheck(salesId, nameof(salesId));
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new UpdateCreditCardAuthTransBySalesIdRequest(salesId, isExpired, approvalType)).ConfigureAwait(false)).Item;
        }

        [HttpGet]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> RunDunningService(IEndpointContext ctx)
        {
            await ctx.ExecuteAsync<NullResponse>(new RunDunningServiceRequest()).ConfigureAwait(false);
            return true;
        }

        /// <summary>
        /// To get the list of Online customers with Ledger balance in D365.
        /// </summary>
        /// <returns>List of Customer Accounts with D365 Balances</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Application)]
        public async Task<string> GetCustomersWithD365Balance(IEndpointContext ctx)
        {
            return (await ctx.ExecuteAsync<DataResponse<string>>(new GetCustomersWithD365BalanceRequest()).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Clears the customer ledger balance either indiviually or at bulk.
        /// </summary>
        /// <param name="parameters">parameters with string: CustomerAccount and IsAll for bulk update.</param>
        /// <returns>200/OK if successful, else 400/BadRequest.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> SettleCustomerLedgerBalance(IEndpointContext ctx, string custAccount, bool isAll)
        {
            ResponseHelper.NullCheck(custAccount, nameof(custAccount));
            ResponseHelper.NullCheck(isAll, nameof(isAll));
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new SettleCustomerLedgerBalanceRequest(custAccount, isAll)).ConfigureAwait(false)).Item;
        }

        /// <summary>
        /// Store Online Order for List of MSA or at bulk.
        /// </summary>
        /// <param name="parameters">parameters with string: CustomerAccount and IsAll for bulk update.</param>
        /// <returns>200/OK if successful, else 400/BadRequest.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Application)]
        public async Task<bool> SaveOnlineOrdersInRedis(IEndpointContext ctx, string puid)
        {
            ResponseHelper.NullCheck(puid, nameof(puid));
            return (await ctx.ExecuteAsync<DataResponse<bool>>(new SaveOnlineOrdersInRedisRequest(puid)).ConfigureAwait(false)).Item;
        }
    }
}
