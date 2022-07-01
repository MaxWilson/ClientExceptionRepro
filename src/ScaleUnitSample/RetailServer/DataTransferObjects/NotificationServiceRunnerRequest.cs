// <copyright file="RunnerRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions.OData
{
    using System;

    public partial class NotificationServiceRunnerRequest
    {
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Corelation ID.
        /// </summary>w
        public string CorelationID { get; set; }

        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the Cancel Reason.
        /// </summary>
        public string CancelReason { get; set; }

        /// <summary>
        /// Gets or sets the Store Number.
        /// </summary>
        public string StoreNumber { get; set; }

        /// <summary>
        /// Gets or sets the Created Time.
        /// </summary>
        public DateTimeOffset? CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the BOH AssignedTime.
        /// </summary>
        public DateTimeOffset? BOHAssignedTime { get; set; }

        /// <summary>
        /// Gets or sets the End Time.
        /// </summary>
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the Special Instructions.
        /// </summary>
        public string SpecialInstructions { get; set; }

        /// <summary>
        /// Gets or sets the Action Needed Start Time.
        /// </summary>
        public DateTimeOffset? ActionNeededStartTime { get; set; }

        /// <summary>
        /// Gets or sets the Modified Time.
        /// </summary>
        public DateTimeOffset? ModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the placeholder.
        /// </summary>
        public string MS_CV { get; set; }

        /// <summary>
        /// Gets or sets the Transaction Order Id.
        /// </summary>
        public string TransactionOrderId { get; set; }

        /// <summary>
        /// Gets or sets the Purchase Order Id.
        /// </summary>
        public string PurchaseOrderId { get; set; }

        /// <summary>
        /// Gets or sets the Online Short Order Num.
        /// </summary>
        public string OnlineShortOrderNum { get; set; }

        /// <summary>
        /// Gets or sets the Order Type.
        /// </summary>
        public int OrderType { get; set; }

        /// <summary>
        /// Gets or sets the Customer Name.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the FOH Alias.
        /// </summary>
        public string FOHAlias { get; set; }

        /// <summary>
        /// Gets or sets the BOH Alias.
        /// </summary>
        public string BOHAlias { get; set; }

        /// <summary>
        /// Gets or sets the Canceled Alias.
        /// </summary>
        public string CanceledAlias { get; set; }

        /// <summary>
        /// Gets or sets the Floor Level.
        /// </summary>
        public int FloorLevel { get; set; }

        /// <summary>
        /// Gets or sets the Location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the InventoryAction.
        /// </summary>
        public int InventoryAction { get; set; }

        /// <summary>
        /// Gets or sets the Location Notes.
        /// </summary>
        public string HoldLocationNotes { get; set; }

        /// <summary>
        /// Gets or sets the Shipping Address.
        /// </summary>
        public string ShippingAddress { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the Wrapped property is set or not.
        /// </summary>
        public bool Wrapped { get; set; }

        /// <summary>
        /// Gets or sets the placeholder.
        /// </summary>
        public string Affiliation { get; set; }

        /// <summary>
        /// Gets or sets the placeholder.
        /// </summary>
        public NotificationServiceSkuItem[] SkuItems { get; set; }
    }
}
