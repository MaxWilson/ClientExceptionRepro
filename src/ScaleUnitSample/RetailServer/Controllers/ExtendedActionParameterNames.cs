// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtendedActionParameterNames.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//  The extended action parameter names.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.RetailServer.Extensions
{
    /// <summary>
    /// The extended action parameter names.
    /// </summary>
    public static class ExtendedActionParameterNames
    {
        /// <summary>
        /// PUID Identifier.
        /// </summary>
        public const string Puid = "puid";

        /// <summary>
        /// The cart doc.
        /// </summary>
        public const string CartDoc = "cartDoc";

        /// <summary>
        /// Update Sales Order data.
        /// </summary>
        public const string UpdateSalesOrderData = "updateSalesOrderData";

        /// <summary>
        /// Update Sales line data.
        /// </summary>
        public const string UpdateSalesLineData = "updateSalesLineData";

        /// <summary>
        /// Short Order Id.
        /// </summary>
        public const string ShortOrderId = "shortOrderId";

        /// <summary>
        /// CustomerEmailAddress.
        /// </summary>
        public const string CustomerEmailAddress = "customerEmailAddress";

        /// <summary>
        /// Tracking Id.
        /// </summary>
        public const string TrackingId = "trackingId";

		/// <summary>
		/// Payment status for online payment trasaction tracking.
		/// </summary>
		public const string PaymentStatus = "paymentStatus";

		/// <summary>
		/// Manual Review decision.
		/// </summary>
		public const string ManualReviewDecision = "decision";

        /// <summary>
        /// Manual Review risk id.
        /// </summary>
        public const string RiskId = "riskId";

        /// <summary>
        /// Sales order Identifier.
        /// </summary>
        public const string SalesId = "salesId";

        /// <summary>
        /// The line number.
        /// </summary>
        public const string LineNum = "lineNum";

        /// <summary>
        /// Sales order Identifier.
        /// </summary>
        public const string NewAuth = "newAuth";

        /// <summary>
        /// Sales Line Ids Identifier.
        /// </summary>
        public const string SalesLineIds = "salesLineIds";

        /// <summary>
        /// Sales Fulfillment State Identifier.
        /// </summary>
        public const string FulfillmentState = "fulfillmentState";

        /// <summary>
        /// Update Sales lines data.
        /// </summary>
        public const string UpdateSalesLinesData = "updateSalesLinesData";

        /// <summary>
        /// Update Sales lines data.
        /// </summary>
        public const string TransactionId = "transactionId";

        /// <summary>
        /// Sales Line Ids Identifier.
        /// </summary>
        public const string TransactionLineNums = "transactionLineNums";

        /// <summary>
        /// Identify if the request is for partial refund.
        /// </summary>
        public const string IsPartialRefund = "isPartialRefund";

        /// <summary>
        /// The detail of partial refund sales line, include sales line number and refund amount.
        /// </summary>
        public const string RefundSalesLinesDetail = "refundSalesLinesDetail";

        /// <summary>
        /// The detail of cancel sales lines along with reason code.
        /// </summary>
        public const string CancelSalesLinesDetail = "cancelSalesLinesDetail";

        /// <summary>
        /// Payment instrument id.
        /// </summary>
        public const string PaymentInstrumentId = "paymentInstrumentId";

        /// <summary>
        /// ReleasedProductRecIds Identifier.
        /// </summary>
        public const string ReleasedProductRecIds = "releasedProductRecIds";

        /// <summary>
        /// Invoice ID to be reversed for chargeback.
        /// </summary>
        public const string InvoiceId = "invoiceId";

        /// <summary>
        /// Chargeback Reference ID from external source.
        /// </summary>
        public const string ChargebackReferenceId = "chargebackReferenceId";

        /// <summary>
        /// The amount of the chargeback.
        /// </summary>
        public const string ChargebackAmount = "chargebackAmount";

        /// <summary>
        /// The transaction ID which the tax invoice is for.
        /// </summary>
        public const string TaxInvoiceTransactionId = "transactionId";

        /// <summary>
        /// The line number which the tax invoice is for.
        /// </summary>
        public const string TaxInvoiceLineNum = "lineNum";

        /// <summary>
        /// The tax invoice ID.
        /// </summary>
        public const string TaxInvoiceTaxInvoiceId = "taxInvoiceId";

        /// <summary>
        /// Whether the tax invoice represents a refund.
        /// </summary>
        public const string TaxInvoiceIsRefund = "isRefund";

        /// <summary>
        /// User friendly invoice number.
        /// </summary>
        public const string InvoiceNumber = "invoiceNumber";

        /// <summary>
        /// Force Reinvoice.
        /// </summary>
        public const string ForceReinvoice = "forceReinvoice";

        /// <summary>
        /// Storage Location.
        /// </summary>
        public const string StorageLocation = "storageLocation";

        /// <summary>
        /// Credit card auth trans rec id.
        /// </summary>
        public const string CreditCardAuthTransRecId = "recId";

        /// <summary>
        /// Credit card auth trans approval voided.
        /// </summary>
        public const string CreditCardAuthTransIsVoided = "isVoided";

        /// <summary>
        /// Credit card auth trans approval expired.
        /// </summary>
        public const string CreditCardAuthTransIsExpired = "isExpired";

        /// <summary>
        /// Credit card auth trans invoice id.
        /// </summary>
        public const string CreditCardAuthTransInvoiceId = "invoiceId";

        /// <summary>
        /// Credit card auth trans tracking id.
        /// </summary>
        public const string CreditCardAuthTransTrackingId = "trackingId";

        /// <summary>
        /// Credit card auth trans approved date.
        /// </summary>
        public const string CreditCardAuthTransApprovedDate = "approvedDate";

        /// <summary>
        /// Credit card auth trans approved date.
        /// </summary>
        public const string CreditCardAuthTransProcessorStatus = "processorStatus";

        /// <summary>
        /// Credit card auth trans approved date.
        /// </summary>
        public const string CreditCardAuthTransApprovalAmount = "approvalAmount";

        /// <summary>
        /// Credit card auth trans rec id.
        /// </summary>
        public const string CreditCardAuthTransCardResultRecId = "cardResultRecId";

        /// <summary>
        /// Credit card auth trans AuthApprovalCodeOverride.
        /// </summary>
        public const string CreditCardAuthTransAuthApprovalCodeOverride = "authApprovalCodeOverride";

        /// <summary>
        /// Credit card auth trans CaptureAmountOverride.
        /// </summary>
        public const string CreditCardAuthTransCaptureAmountOverride = "captureAmountOverride";

        /// <summary>
        /// Credit card auth trans RefundAmountOverride.
        /// </summary>
        public const string CreditCardAuthTransRefundAmountOverride = "refundAmountOverride";

        /// <summary>
        /// RetailTransactionSalesTrans RecId.
        /// </summary>
        public const string RetailTransactionSalesTransRecId = "salesTransRecId";

        /// <summary>
        /// RetailTransactionSalesTrans TransactionStatus.
        /// </summary>
        public const string RetailTransactionSalesTransTransactionStatus = "transactionStatus";

        /// <summary>
        /// RetailTransactionSalesTrans CreditCardAuthTrans RecId.
        /// </summary>
        public const string CreditCardAuthTransRecIdSalesTrans = "salesTransCCRecId";

        /// <summary>
        /// RetailTransactionSalesTrans Refund CreditCardAuthTrans RecId.
        /// </summary>
        public const string CreditCardAuthTransRefundRecIdSalesTrans = "salesTransRefundCCRecId";

        /// <summary>
        /// RetailTransactionSalesTrans Requested Refund Type.
        /// </summary>
        public const string CreditCardAuthTransRefundTypeSalesTrans = "salesTransRefundType";

        /// <summary>
        /// RetailTransactionSalesTrans Requested Refund Amount.
        /// </summary>
        public const string CreditCardAuthTransRefundAmountSalesTrans = "salesTransRefundAmount";

        /// <summary>
        /// RetailTransactionSalesTrans isRefundable.
        /// </summary>
        public const string IsRefundable = "isRefundable";

        /// <summary>
        /// Dunning start date for fixing.
        /// </summary>
        public const string DunningStartDate = "dunningStartDate";

        /// <summary>
        /// Dunning Status.
        /// </summary>
        public const string DunningStatus = "dunningStatus";

        /// <summary>
        /// Dunning Business Event Status.
        /// </summary>
        public const string DunningBusinessEventStatus = "dunningBusinessEventStatus";

        /// <summary>
        /// Quantity group id.
        /// </summary>
        public const string QuantityGroupId = "quantityGroupId";

        /// <summary>
        /// Sales Order Ids.
        /// </summary>
        public const string SalesIds = "salesIds";

        /// <summary>
        /// RetailTransactionTable RecId.
        /// </summary>
        public const string RetailTransactionTableRecId = "transactionRecId";

        /// <summary>
        /// RetailTransactionTable JarvisCid.
        /// </summary>
        public const string JarvisCid = "jarvisCid";

        /// <summary>
        /// RetailTransactionTable JarvisProfileId.
        /// </summary>
        public const string JarvisProfileId = "jarvisProfileId";

        /// <summary>
        /// Order start date for fixing.
        /// </summary>
        public const string OrderStartDate = "orderStartDate";

        /// <summary>
        /// Order end date for fixing.
        /// </summary>
        public const string OrderEndDate = "orderEndDate";

        /// <summary>
        /// Check for Manual Review update.
        /// </summary>
        public const string IsManualReviewUpdate = "isManualReviewUpdate";

        /// <summary>
        /// Check for invoicing.
        /// </summary>
        public const string IsInvoicingRequired = "isInvoicingRequired";

        /// <summary>
        /// Check for BillingState Update.
        /// </summary>
        public const string IsBillingStateUpdateRequired = "isBillingStateUpdateRequired";

        /// <summary>
        /// Check for eTag Update.
        /// </summary>
        public const string IseTagUpdate = "iseTagUpdate";

        /// <summary>
        /// Address ID for eTag update.
        /// </summary>
        public const string AddressID = "addressID";

        /// <summary>
        /// Check for Voiding salesline Update.
        /// </summary>
        public const string IsCancelSalesRequired = "isCancelSalesRequired";

        /// <summary>
        /// Check for approving manual review.
        /// </summary>
        public const string ApproveManualReview = "approveManualReview";

        /// <summary>
        /// Credit card auth trans approval type.
        /// </summary>
        public const string CreditCardAuthTransApprovalType = "approvalType";

        /// <summary>
        /// Table Name.
        /// </summary>
        public const string TableName = "tableName";

        /// <summary>
        /// Column Name.
        /// </summary>
        public const string FilterBy = "filterBy";

        /// <summary>
        /// Column Value.
        /// </summary>
        public const string FilterValue = "filterValue";

        /// <summary>
        /// records to return.
        /// </summary>
        public const string TopFilter = "top";

        /// <summary>
        /// skip records.
        /// </summary>
        public const string SkipFilter = "skip";

        /// <summary>
        /// records to return.
        /// </summary>
        public const string OrderBy = "orderBy";

        /// <summary>
        /// Customer Account Number.
        /// </summary>
        public const string CustAccount = "custAccount";

        /// <summary>
        /// Is all records.
        /// </summary>
        public const string IsAll = "isAll";

        /// <summary>
        /// Is all records.
        /// </summary>
        public const string PaymentType = "paymentType";

        /// <summary>
        /// Is update Refunded Total Amount required.
        /// </summary>
        public const string UpdateRefundedTotalAmount = "updateRefundedTotalAmount";

        /// <summary>
        /// Is update TestScenarios required.
        /// </summary>
        public const string TestScenarios = "testScenarios";

        /// <summary>
        /// Product Reservation Id.
        /// </summary>
        public const string ReservationId = "reservationId";

        /// <summary>
        /// Suppress Email for Reauth Failure.
        /// </summary>
        public const string SuppressEmail = "suppressEmail";

        /// <summary>
        /// SalesOrder Line Amount.
        /// </summary>
        public const string LineAmount = "lineAmount";

        /// <summary>
        /// MerchantReferenceNumber for CCAT.
        /// </summary>
        public const string MerchantReferenceNumber = "merchantReferenceNumber";
    }
}
