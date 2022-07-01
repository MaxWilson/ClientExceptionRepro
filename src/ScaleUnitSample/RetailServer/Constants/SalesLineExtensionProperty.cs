// <copyright file="SalesLineExtensionProperty.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.MSE.D365.CommerceRuntime.Extensions
{
    /// <summary>
    /// Represents a class that contains sales line extension property names.
    /// </summary>
    public sealed class SalesLineExtensionProperty
    {
        /// <summary>
        /// The transaction identifier property name.
        /// </summary>
        public const string TransactionIdProperty = "TransactionId";

        /// <summary>
        /// The customer account identifier property name.
        /// </summary>
        public const string CustAccountProperty = "CustAccount";

        /// <summary>
        /// The Line number property name.
        /// </summary>
        public const string LineNumProperty = "LineNum";

        /// <summary>
        /// The Billing State property name.
        /// </summary>
        public const string BillingStateProperty = "BillingState";

        /// <summary>
        /// The Fulfillment State property name.
        /// </summary>
        public const string FulfillmentStateProperty = "FulfillmentState";

        /// <summary>
        /// The FulfillmentId property name.
        /// </summary>
        public const string FulfillmentIdProperty = "FulfillmentId";

        /// <summary>
        /// The Reservation Id property name.
        /// </summary>
        public const string OCReservationIdProperty = "OCReservationId";

        /// <summary>
        /// The PSA property name.
        /// </summary>
        public const string PSAProperty = "PSA";

        /// <summary>
        /// The PSA property name.
        /// </summary>
        public const string OrderLineTypeProperty = "OrderLineType";

        /// <summary>
        /// The Charged PrimaryPaymentId property name.
        /// </summary>
        public const string ChargedPrimaryPaymentIdProperty = "ChargedPrimaryPaymentId";

        /// <summary>
        /// The Charged TopoffPaymentId property name.
        /// </summary>
        public const string ChargedTopOffPaymentIdProperty = "ChargedTopoffPaymentId";

        /// <summary>
        /// The Charged PrimaryPaymentAmount property name.
        /// </summary>
        public const string ChargedPrimaryPaymentAmountProperty = "ChargedPrimaryPaymentAmount";

        /// <summary>
        /// The Charged TopoffPaymentAmount property name.
        /// </summary>
        public const string ChargedTopOffPaymentAmountProperty = "ChargedTopoffPaymentAmount";

        /// <summary>
        /// The BundleId property name.
        /// </summary>
        public const string BundleIdProperty = "BundleId";

        /// <summary>
        /// The Bundle InstanceId property name.
        /// </summary>
        public const string BundleInstanceIdProperty = "BundleInstanceId";

        /// <summary>
        /// The QuantityGroupId property name.
        /// </summary>
        public const string QuantityGroupIdProperty = "QuantityGroupId";

        /// <summary>
        /// The Topoff Rma Id property name.
        /// </summary>
        public const string RmaIdProperty = "RmaId";

        /// <summary>
        /// The Token hash property name.
        /// </summary>
        public const string TokenHashProperty = "TokenHash";

        /// <summary>
        /// The Redeemed OrderId property name.
        /// </summary>
        public const string RedeemedOrderIdProperty = "RedeemedOrderId";

        /// <summary>
        /// The Recurrence Id property name.
        /// </summary>
        public const string RecurrenceIdProperty = "RecurrenceId";

        /// <summary>
        /// The PSA property name.
        /// </summary>
        public const string TokenizePSAProperty = "TokenizePSA";

        /// <summary>
        /// The PSA property name.
        /// </summary>
        public const string AssetIdProperty = "AssetId";

        /// <summary>
        /// The PSA property name.
        /// </summary>
        public const string AssetSourceProperty = "AssetSource";

        /// <summary>
        /// The Bundle Slot type property name.
        /// </summary>
        public const string BundleSlotTypeProperty = "BundleSlotType";

        /// <summary>
        /// The Bundle Slot id property name.
        /// </summary>
        public const string BundleSlotIdProperty = "BundleSlotId";

        /// <summary>
        /// The Canceled reason property name.
        /// </summary>
        public const string CanceledReasonProperty = "CanceledReason";

        /// <summary>
        /// The Refunded reason property name.
        /// </summary>
        public const string RefundedReasonProperty = "RefundedReason";

        /// <summary>
        /// The Returned reason property name.
        /// </summary>
        public const string ReturnedReasonProperty = "ReturnedReason";

        /// <summary>
        /// The Canceled date property name.
        /// </summary>
        public const string CanceledDateProperty = "CanceledDate";

        /// <summary>
        /// The Refunded date property name.
        /// </summary>
        public const string RefundedDateProperty = "RefundedDate";

        /// <summary>
        /// The Returned date property name.
        /// </summary>
        public const string ReturnedDateProperty = "ReturnedDate";

        /// <summary>
        /// The Refunded Total Amount property name.
        /// </summary>
        public const string RefundedTotalAmountProperty = "RefundedTotalAmount";

        /// <summary>
        /// The Refunded tax amount property name.
        /// </summary>
        public const string RefundedTaxAmountProperty = "RefundedTaxAmount";

        /// <summary>
        /// The Refunded product sales price property name.
        /// </summary>
        public const string RefundedPriceProperty = "RefundedPrice";

        /// <summary>
        /// The sales order line refundable property name.
        /// </summary>
        public const string MSEOnlineOrderLineRefundableProperty = "MSEOnlineOrderLineRefundable";

        /// <summary>
        ///  The JsonTrackingIds property name.
        /// </summary>
        public const string JsonTrackingIdsProperty = "JsonTrackingIds";

        /// <summary>
        ///  The ShippingPlantId property name.
        /// </summary>
        public const string ShippingPlantIdProperty = "ShippingPlantId";

        /// <summary>
        ///  The Fulfillment Retry count property name.
        /// </summary>
        public const string FulfillmentRetryCountProperty = "FulfillmentRetryCount";

        /// <summary>
        ///  The Fulfillment Retry count property name.
        /// </summary>
        public const string FulfillmentRetryCheckDateProperty = "FulfillmentRetryCheckDate";

        /// <summary>
        ///  The FulfillmentComment property name.
        /// </summary>
        public const string FulfillmentCommentProperty = "FulfillmentComment";

        /// <summary>
        ///  The SessionId property name.
        /// </summary>
        public const string SessionIdProperty = "SessionId";

        /// <summary>
        /// The Fulfillment Data property name.
        /// </summary>
        public const string FulfillmentDataProperty = "FulfillmentData";

        /// <summary>
        /// The DeliveryMethodId property name.
        /// </summary>
        public const string DeliveryMethodIdProperty = "DeliveryMethodId";

        /// <summary>
        /// The EstimatedDeliveryDate property name.
        /// </summary>
        public const string EstimatedDeliveryDateProperty = "EstimatedDeliveryDate";

        /// <summary>
        /// The RenderEDD property name.
        /// </summary>
        public const string RenderEDDProperty = "RenderEDD";

        /// <summary>
        /// The RenderEDDOverride property name.
        /// </summary>
        public const string RenderEDDOverrideProperty = "RenderEDDOverride";

        /// <summary>
        /// The Distributor property name.
        /// </summary>
        public const string DistributorProperty = "DistributorProperty";
        /// <summary>
        /// The TaxInvoiceId property name.
        /// </summary>
        public const string TaxInvoiceId = "TaxInvoiceId";

        /// <summary>
        /// The TaxRefundInvoiceIds property name.
        /// </summary>
        public const string TaxRefundInvoiceIds = "TaxRefundInvoiceIds";

        /// <summary>
        /// The OptionalCampaignId property name.
        /// </summary>
        public const string OptionalCampaignId = "OptionalCampaignId";

        /// <summary>
        /// The CampaignId property name.
        /// </summary>
        public const string CampaignId = "CampaignId";

        /// <summary>
        /// The FulfilledDate property name.
        /// </summary>
        public const string FulfilledDate = "FULFILLEDDATE";
    }
}