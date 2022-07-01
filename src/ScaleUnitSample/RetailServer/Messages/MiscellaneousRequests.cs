// <copyright file="DFSCustomerLookupRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

// One file for a bunch of requests. May refactor to separate files after.
namespace MSE.D365.RetailServer.Extensions
{
    using global::MSE.D365.Library.DellFinanceService.DFS.DataModel.LookupCustomer;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using Microsoft.MSE.D365.Library;
    using MSE.D365.RetailServer.Extensions.OData;
    using MSE.D365.Library.OnlineRefunds;
    using System;
    using System.Collections.Generic;

    public class SerialNumberRequest : Request
    {
        public SerialNumberRequest(string itemId, string serialNumber)
        {
            this.ItemId = itemId;
            this.SerialNumber = serialNumber;
        }

        public string ItemId { get; }

        public string SerialNumber { get; }
    }

    public class AuthenticateRequest : Request
    {
        public AuthenticateRequest(string staffId, string passwordData)
        {
            StaffId = staffId;
            PasswordData = passwordData;
        }

        public string StaffId { get; }
        public string PasswordData { get; }
    }

    public class RequestRunnerICERequest : Request
    {
        public RequestRunnerICERequest(RunnerRequest runnerRequest)
        {
            RunnerRequest = runnerRequest;
        }

        public RunnerRequest RunnerRequest { get; }
    }

    public class CancelRunnerICERequest : Request
    {
        public CancelRunnerICERequest(string id, string employeeAlias)
        {
            Id = id;
            EmployeeAlias = employeeAlias;
        }

        public string Id { get; }

        public string EmployeeAlias { get; }
    }

    public class CompleteRunnerICERequest : Request
    {
        public CompleteRunnerICERequest(string id, string employeeAlias)
        {
            Id = id;
            EmployeeAlias = employeeAlias;
        }

        public string Id { get; }

        public string EmployeeAlias { get; }
    }

    public class RefreshRunnerICERequest : Request
    {
        public RefreshRunnerICERequest(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }

    public class LogDataBulkRequest : Request
    {
        public LogDataBulkRequest(global::MSE.D365.Library.Telemetry.LogList logList)
        {
            LogList = logList;
        }

        public global::MSE.D365.Library.Telemetry.LogList LogList { get; }
    }

    public class GetExpectedCashTotalBalanceRequest : Request { }

    public class DeclareEndOfDayBalanceActionRequest : Request
    {
        public DeclareEndOfDayBalanceActionRequest(decimal balance)
        {
            Balance = balance;
        }

        public decimal Balance { get; }
    }

    public class SystemHealthCheckRequest : Request { }

    public class CalculateTaxRequest : Request
    {
        public CalculateTaxRequest(SalesTransaction salesTransaction)
        {
            SalesTransaction = salesTransaction;
        }

        public SalesTransaction SalesTransaction { get; }
    }

    public class GetPOBOCustomerCartsRequest : Request
    {
        public GetPOBOCustomerCartsRequest(long puid)
        {
            Puid = puid;
        }

        public long Puid { get; }
    }

    public class GetPOBOCartRequest : Request
    {
        public GetPOBOCartRequest(string cartId)
        {
            CartId = cartId;
        }

        public string CartId { get; }
    }

    public class GetPOBOCartByFriendlyIdRequest : Request
    {
        public GetPOBOCartByFriendlyIdRequest(string friendlyId)
        {
            FriendlyId = friendlyId;
        }

        public string FriendlyId { get; }
    }

    public class AcceptPOBOCartRequest : Request
    {
        public AcceptPOBOCartRequest(string cartId)
        {
            CartId = cartId;
        }

        public string CartId { get; }
    }

    public class UpdateManualReviewActionRequest : Request
    {
        public UpdateManualReviewActionRequest(string riskId, string decision)
        {
            RiskId = riskId;
            Decision = decision;
        }

        public string RiskId { get; }
        public string Decision { get; }
    }

    public class UpdateManualReviewBySalesIdRequest : Request
    {
        public UpdateManualReviewBySalesIdRequest(string salesId, string decision)
        {
            SalesId = salesId;
            Decision = decision;
        }

        public string SalesId { get; }
        public string Decision { get; }
    }

    public class TryCreateCustomerRequest : Request
    {
        public TryCreateCustomerRequest(string email, string fullName, string firstName, string lastName, string phone)
        {
            Email = email;
            FullName = fullName;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public string Email { get; }

        public string FullName { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public string Phone { get; }
    }

    public class GetActivePricesRequest : Request
    {
        public GetActivePricesRequest(ProjectionDomain projectDomain, IEnumerable<long> productIds, DateTimeOffset activeDate, string customerId, bool includeSimpleDiscountsInContextualPrice, IEnumerable<AffiliationLoyaltyTier> affiliationLoyaltyTiers)
        {
            ProjectDomain = projectDomain;
            ProductIds = productIds;
            ActiveDate = activeDate;
            CustomerId = customerId;
            IncludeSimpleDiscountsInContextualPrice = includeSimpleDiscountsInContextualPrice;
            AffiliationLoyaltyTiers = affiliationLoyaltyTiers;
        }

        public ProjectionDomain ProjectDomain { get; }
        public IEnumerable<long> ProductIds { get; }
        public DateTimeOffset ActiveDate { get; }
        public string CustomerId { get; }
        public bool IncludeSimpleDiscountsInContextualPrice { get; }
        public IEnumerable<AffiliationLoyaltyTier> AffiliationLoyaltyTiers { get; }
    }

    public class BulkGetActivePricesRequest : Request
    {
        public BulkGetActivePricesRequest(ProjectionDomain projectDomain, IEnumerable<long> productIds, DateTimeOffset activeDate, string customerId, bool includeSimpleDiscountsInContextualPrice)
        {
            ProjectDomain = projectDomain;
            ProductIds = productIds;
            ActiveDate = activeDate;
            CustomerId = customerId;
            IncludeSimpleDiscountsInContextualPrice = includeSimpleDiscountsInContextualPrice;
        }

        public ProjectionDomain ProjectDomain { get; }
        public IEnumerable<long> ProductIds { get; }
        public DateTimeOffset ActiveDate { get; }
        public string CustomerId { get; }
        public bool IncludeSimpleDiscountsInContextualPrice { get; }
    }

    public class GetTableRecordsActionRequest : Request
    {
        public GetTableRecordsActionRequest(string tableName, global::MSE.D365.Library.OnlineOrder.StorageLocation storageLocation, string filterBy, string filterValue, int top, int skip, string orderBy)
        {
            TableName = tableName;
            StorageLocation = storageLocation;
            FilterBy = filterBy;
            FilterValue = filterValue;
            Top = top;
            Skip = skip;
            OrderBy = orderBy;
        }

        public string TableName { get; }
        public global::MSE.D365.Library.OnlineOrder.StorageLocation StorageLocation { get; }
        public string FilterBy { get; }
        public string FilterValue { get; }
        public int Top { get; }
        public int Skip { get; }
        public string OrderBy { get; }
    }

    public class UpdateSalesRecordsRequest : Request
    {
        public UpdateSalesRecordsRequest(DateTimeOffset orderStartDate, DateTimeOffset orderEndDate, bool isManualReviewUpdate, bool isInvoicingRequired, bool isBillingStateUpdateRequired, bool iseTagUpdate, string addressID, bool isCancelSalesRequired, bool approveManualReview, string salesId, bool updateRefundedTotalAmount)
        {
            OrderStartDate = orderStartDate;
            OrderEndDate = orderEndDate;
            IsManualReviewUpdate = isManualReviewUpdate;
            IsInvoicingRequired = isInvoicingRequired;
            IsBillingStateUpdateRequired = isBillingStateUpdateRequired;
            IseTagUpdate = iseTagUpdate;
            AddressID = addressID;
            IsCancelSalesRequired = isCancelSalesRequired;
            ApproveManualReview = approveManualReview;
            SalesId = salesId;
            UpdateRefundedTotalAmount = updateRefundedTotalAmount;
        }

        public DateTimeOffset OrderStartDate { get; }
        public DateTimeOffset OrderEndDate { get; }
        public bool IsManualReviewUpdate { get; }
        public bool IsInvoicingRequired { get; }
        public bool IsBillingStateUpdateRequired { get; }
        public bool IseTagUpdate { get; }
        public string AddressID { get; }
        public bool IsCancelSalesRequired { get; }
        public bool ApproveManualReview { get; }
        public string SalesId { get; }
        public bool UpdateRefundedTotalAmount { get; }
    }

    public class SettleCustomerLedgerBalanceRequest : Request
    {
        public SettleCustomerLedgerBalanceRequest(string custAccount, bool isAll)
        {
            CustAccount = custAccount;
            IsAll = isAll;
        }

        public string CustAccount { get; }
        public bool IsAll { get; }
    }

    public class UpdateSalesLineActionRequest : Request
    {
        public UpdateSalesLineActionRequest(string salesId, string lineNum, DateTimeOffset dunningStartDate, int dunningStatus, int dunningBusinessEventStatus, decimal lineAmount)
        {
            SalesId = salesId;
            LineNum = lineNum;
            DunningStartDate = dunningStartDate;
            DunningStatus = dunningStatus;
            DunningBusinessEventStatus = dunningBusinessEventStatus;
            LineAmount = lineAmount;
        }

        public string SalesId { get; }
        public string LineNum { get; }
        public DateTimeOffset DunningStartDate { get; }
        public int DunningStatus { get; }
        public int DunningBusinessEventStatus { get; }
        public decimal LineAmount { get; }
    }

    public class UpdateCCAuthTransActionRequest : Request
    {
        public UpdateCCAuthTransActionRequest(long recId, bool isVoided, bool isExpired, string invoiceId, string trackingId, DateTimeOffset approvedDate, int processorStatus, decimal approvalAmount1, string paymentType, string testScenarios, long cardResultRecId, string authApprovalCodeOverride, decimal captureAmountOverride, decimal refundAmountOverride, long salesTransRecId, long salesTransCCRecId, long salesTransRefundCCRecId, int salesTransRefundType, decimal salesTransRefundAmount, int transactionStatus1, int dunningStatus1, DateTimeOffset dunningStartDate1, bool isRefundable, long transactionRecId, long puid, string jarvisCid, string jarvisProfileId)
        {
            RecId = recId;
            IsVoided = isVoided;
            IsExpired = isExpired;
            InvoiceId = invoiceId;
            TrackingId = trackingId;
            ApprovedDate = approvedDate;
            ProcessorStatus = processorStatus;
            ApprovalAmount1 = approvalAmount1;
            PaymentType = paymentType;
            TestScenarios = testScenarios;
            CardResultRecId = cardResultRecId;
            AuthApprovalCodeOverride = authApprovalCodeOverride;
            CaptureAmountOverride = captureAmountOverride;
            RefundAmountOverride = refundAmountOverride;
            SalesTransRecId = salesTransRecId;
            SalesTransCCRecId = salesTransCCRecId;
            SalesTransRefundCCRecId = salesTransRefundCCRecId;
            SalesTransRefundType = salesTransRefundType;
            SalesTransRefundAmount = salesTransRefundAmount;
            TransactionStatus1 = transactionStatus1;
            DunningStatus1 = dunningStatus1;
            DunningStartDate1 = dunningStartDate1;
            IsRefundable = isRefundable;
            TransactionRecId = transactionRecId;
            Puid = puid;
            JarvisCid = jarvisCid;
            JarvisProfileId = jarvisProfileId;
        }

        public long RecId { get; }
        public bool IsVoided { get; }
        public bool IsExpired { get; }
        public string InvoiceId { get; }
        public string TrackingId { get; }
        public DateTimeOffset ApprovedDate { get; }
        public int ProcessorStatus { get; }
        public decimal ApprovalAmount1 { get; }
        public string PaymentType { get; }
        public string TestScenarios { get; }
        public long CardResultRecId { get; }
        public string AuthApprovalCodeOverride { get; }
        public decimal CaptureAmountOverride { get; }
        public decimal RefundAmountOverride { get; }
        public long SalesTransRecId { get; }
        public long SalesTransCCRecId { get; }
        public long SalesTransRefundCCRecId { get; }
        public int SalesTransRefundType { get; }
        public decimal SalesTransRefundAmount { get; }
        public int TransactionStatus1 { get; }
        public int DunningStatus1 { get; }
        public DateTimeOffset DunningStartDate1 { get; }
        public bool IsRefundable { get; }
        public long TransactionRecId { get; }
        public long Puid { get; }
        public string JarvisCid { get; }
        public string JarvisProfileId { get; }
    }

    public class CreateCCATRecordActionRequest : Request
    {
        public CreateCCATRecordActionRequest(string salesId, string invoiceId, string merchantReferenceNumber, string trackingId)
        {
            SalesId = salesId;
            InvoiceId = invoiceId;
            MerchantReferenceNumber = merchantReferenceNumber;
            TrackingId = trackingId;
        }

        public string SalesId { get; }
        public string InvoiceId { get; }
        public string MerchantReferenceNumber { get; }
        public string TrackingId { get; }
    }

    public class GetCustomersWithD365BalanceRequest : Request { }

    public class UpdateCreditCardAuthTransBySalesIdRequest : Request
    {
        public UpdateCreditCardAuthTransBySalesIdRequest(string salesId, bool isExpired, int approvalType)
        {
            SalesId = salesId;
            IsExpired = isExpired;
            ApprovalType = approvalType;
        }

        public string SalesId { get; }
        public bool IsExpired { get; }
        public int ApprovalType { get; }
    }

    public class GetAffiliationsRequest : Request { }

    public class GetAbandonedCartDetailsRequest : Request
    {
        public GetAbandonedCartDetailsRequest(List<Cart> carts, DateTimeOffset? lastModifiedDateTimeFrom, bool isMEOTemplate, GetCartRequest getCartRequest)
        {
            Carts = carts;
            LastModifiedDateTimeFrom = lastModifiedDateTimeFrom;
            IsMEOTemplate = isMEOTemplate;
            GetCartRequest = getCartRequest;
        }

        public List<Cart> Carts { get; }
        public DateTimeOffset? LastModifiedDateTimeFrom { get; }
        public bool IsMEOTemplate { get; }
        public GetCartRequest GetCartRequest { get; }
    }

    public class CancelSalesLinesSalesRequest : Request
    {
        public CancelSalesLinesSalesRequest(long puid, string transactionId, IEnumerable<global::MSE.D365.Library.OnlineOrder.SalesLineDetailRequest> lineDetails, string trackingId)
        {
            Puid = puid;
            TransactionId = transactionId;
            LineDetails = lineDetails;
            TrackingId = trackingId;
        }

        public long Puid { get; }
        public string TransactionId { get; }
        public IEnumerable<global::MSE.D365.Library.OnlineOrder.SalesLineDetailRequest> LineDetails { get; }
        public string TrackingId { get; }
    }

    public class PostSalesOrderSalesRequest : Request
    {
        public PostSalesOrderSalesRequest(string salesId)
        {
            SalesId = salesId;
        }

        public string SalesId { get; }
    }

    public class PostSalesLinesSalesRequest : Request
    {
        public PostSalesLinesSalesRequest(string salesId, IEnumerable<string> salesLineIds, bool forceReinvoice)
        {
            SalesId = salesId;
            SalesLineIds = salesLineIds;
            ForceReinvoice = forceReinvoice;
        }

        public string SalesId { get; }
        public IEnumerable<string> SalesLineIds { get; }
        public bool ForceReinvoice { get; }
    }

    public class UpdateSalesLineSalesRequest : Request
    {
        public UpdateSalesLineSalesRequest(OnlineSalesLineUpdateRequest updateSalesLineData)
        {
            UpdateSalesLineData = updateSalesLineData;
        }

        public OnlineSalesLineUpdateRequest UpdateSalesLineData { get; }
    }

    public class UpdateSalesLinesSalesRequest : Request
    {
        public UpdateSalesLinesSalesRequest(global::MSE.D365.Library.OnlineOrder.OnlineSalesLinesUpdateRequest onlineSalesLinesUpdateRequest)
        {
            OnlineSalesLinesUpdateRequest = onlineSalesLinesUpdateRequest;
        }

        public global::MSE.D365.Library.OnlineOrder.OnlineSalesLinesUpdateRequest OnlineSalesLinesUpdateRequest { get; }
    }

    public class UpdateSalesOrderSalesRequest : Request
    {
        public UpdateSalesOrderSalesRequest(OnlineSalesOrderUpdateRequest salesOrderUpdateRequest)
        {
            SalesOrderUpdateRequest = salesOrderUpdateRequest;
        }

        public OnlineSalesOrderUpdateRequest SalesOrderUpdateRequest { get; }
    }

    public class SendUpdatePIEmailSalesRequest : Request
    {
        public SendUpdatePIEmailSalesRequest(long puid, string transactionId)
        {
            Puid = puid;
            TransactionId = transactionId;
        }

        public long Puid { get; }
        public string TransactionId { get; }
    }

    public class ChargebackSalesRequest : Request
    {
        public ChargebackSalesRequest(string invoiceId, string chargebackReferenceId, decimal chargebackAmount)
        {
            InvoiceId = invoiceId;
            ChargebackReferenceId = chargebackReferenceId;
            ChargebackAmount = chargebackAmount;
        }

        public string InvoiceId { get; }
        public string ChargebackReferenceId { get; }
        public decimal ChargebackAmount { get; }
    }

    public class GetOnlineOrdersSalesRequest : Request { }

    public class GetSalesOrderDetailsByTransactionIdSalesRequest : Request
    {
        public GetSalesOrderDetailsByTransactionIdSalesRequest(string transactionId, SearchLocation searchLocationValue)
        {
            TransactionId = transactionId;
            SearchLocationValue = searchLocationValue;
        }

        public string TransactionId { get; }
        public SearchLocation SearchLocationValue { get; }
    }

    public class ReauthBySalesIdSalesRequest : Request
    {
        public ReauthBySalesIdSalesRequest(string salesId, bool newAuth, bool suppressEmail)
        {
            SalesId = salesId;
            NewAuth = newAuth;
            SuppressEmail = suppressEmail;
        }

        public string SalesId { get; }
        public bool NewAuth { get; }
        public bool SuppressEmail { get; }
    }

    public class RefundSalesLinesSalesRequest : Request
    {
        public RefundSalesLinesSalesRequest(long puid, string trackingId, string salesId, IEnumerable<RefundSalesLineDetail> refundSalesLinesDetail)
        {
            Puid = puid;
            TrackingId = trackingId;
            SalesId = salesId;
            RefundSalesLinesDetail = refundSalesLinesDetail;
        }

        public long Puid { get; }
        public string TrackingId { get; }
        public string SalesId { get; }
        public IEnumerable<RefundSalesLineDetail> RefundSalesLinesDetail { get; }
    }

    public class SearchOnlineOrderForReturnInStoreSalesRequest : Request
    {
        public SearchOnlineOrderForReturnInStoreSalesRequest(string shortOrderId, string customerEmailAddress)
        {
            ShortOrderId = shortOrderId;
            CustomerEmailAddress = customerEmailAddress;
        }

        public string ShortOrderId { get; }
        public string CustomerEmailAddress { get; }
    }

    public class CreatePackingSlipSalesRequest : Request
    {
        public CreatePackingSlipSalesRequest(string salesId)
        {
            SalesId = salesId;
        }

        public string SalesId { get; }
    }

    public class SendReceiptSalesRequest : Request
    {
        public SendReceiptSalesRequest(SearchReceiptCriteria searchCriteria, IEnumerable<ElectronicAddress> recipientAddresses)
        {
            SearchCriteria = searchCriteria;
            RecipientAddresses = recipientAddresses;
        }

        public SearchReceiptCriteria SearchCriteria { get; }
        public IEnumerable<ElectronicAddress> RecipientAddresses { get; }
    }

    public class GetInvoicedSalesLinesBySalesIdsSalesRequest : Request
    {
        public GetInvoicedSalesLinesBySalesIdsSalesRequest(IEnumerable<string> salesIds)
        {
            SalesIds = salesIds;
        }

        public IEnumerable<string> SalesIds { get; }
    }

    public class GetSalesOrderDetailsBySalesIdSalesRequest : Request
    {
        public GetSalesOrderDetailsBySalesIdSalesRequest(string salesId)
        {
            SalesId = salesId;
        }

        public string SalesId { get; }
    }

    public class CreatePickingListForItemsSalesRequest : Request
    {
        public CreatePickingListForItemsSalesRequest(string salesId)
        {
            SalesId = salesId;
        }

        public string SalesId { get; }
    }

    public class SaveOnlineOrdersInRedisRequest : Request
    {
        public SaveOnlineOrdersInRedisRequest(string puid)
        {
            Puid = puid;
        }

        public string Puid { get; }
    }
}
