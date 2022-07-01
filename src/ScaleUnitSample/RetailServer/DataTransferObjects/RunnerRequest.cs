// <copyright file="RunnerRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions.OData
{
    using System;
    using System.Linq;

    public partial class RunnerRequest
    {

        /// expose enums for reference, but we still want it to show up in $metadata as an int (not a string) so RunnerRequest still exposes ints instead of enums for enum-like properties
        /// <summary>
        /// Retail runner request status.
        /// </summary>
        public enum RetailRunnerRequestStatusEnum
        {
            ICEPersonUnavailable = -1,
            Created = 0,
            Canceled = 1,
            Complete = 2,
            InProgress = 3,
            ReadyForPickUp = 4,
        }

        /// <summary>
        /// Order type status.
        /// </summary>
        public enum OrderTypeEnum
        {
            InStoreOrder = 1,
            OnlineOrder = 2,
            DBSOrder = 3,
        }

        /// <summary>
        /// Inventory action status.
        /// </summary>
        public enum InventoryActionEnum
        {
            PickInventory = 0,
            CancelInventory = 1,
            RunnerRequest = 2,
            CompleteInventory = 3,
            ModifyInventory = 4,
            CancelOnlineOrderRunnerRequest = 5,
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        // It's important not to name this Id or RunnerRequestId, or else the framework will think it's an entity type and will not serialize the SkuItems
        public string RunnerRequestRecordId { get; set; }

        /// <summary>
        /// Gets or sets the Corelation ID.
        /// </summary>w
        public string CorrelationId { get; set; }

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
        public SkuItem[] SkuItems { get; set; }

        public NotificationServiceRunnerRequest ToNotificationRunnerRequest() =>
            new NotificationServiceRunnerRequest
            {
                Id = this.RunnerRequestRecordId,
                CorelationID = this.CorrelationId,
                Status = this.Status,
                CancelReason = this.CancelReason,
                CanceledAlias = this.CanceledAlias,
                StoreNumber = this.StoreNumber,
                CreatedTime = this.CreatedTime,
                BOHAssignedTime = this.BOHAssignedTime,
                EndTime = this.EndTime,
                SpecialInstructions = this.SpecialInstructions,
                ActionNeededStartTime = this.ActionNeededStartTime,
                ModifiedTime = this.ModifiedTime,
                MS_CV = this.MS_CV,
                TransactionOrderId = this.TransactionOrderId,
                PurchaseOrderId = this.PurchaseOrderId,
                OnlineShortOrderNum = this.OnlineShortOrderNum,
                OrderType = this.OrderType,
                CustomerName = this.CustomerName,
                Email = this.Email,
                Phone = this.Phone,
                FOHAlias = this.FOHAlias,
                BOHAlias = this.BOHAlias,
                FloorLevel = this.FloorLevel,
                Location = this.Location,
                InventoryAction = this.InventoryAction,
                HoldLocationNotes = this.HoldLocationNotes,
                ShippingAddress = this.ShippingAddress,
                Wrapped = this.Wrapped,
                Affiliation = this.Affiliation,
                SkuItems = this.SkuItems.Select(s => s.ToNotificationSkuItem()).ToArray(),
            };
        public static RunnerRequest FromNotificationRunnerRequest(NotificationServiceRunnerRequest src) =>
            src == null ? null :
            new RunnerRequest
            {
                RunnerRequestRecordId = src.Id,
                CorrelationId = src.CorelationID,
                Status = src.Status,
                CancelReason = src.CancelReason,
                CanceledAlias = src.CanceledAlias,
                StoreNumber = src.StoreNumber,
                CreatedTime = src.CreatedTime,
                BOHAssignedTime = src.BOHAssignedTime,
                EndTime = src.EndTime,
                SpecialInstructions = src.SpecialInstructions,
                ActionNeededStartTime = src.ActionNeededStartTime,
                ModifiedTime = src.ModifiedTime,
                MS_CV = src.MS_CV,
                TransactionOrderId = src.TransactionOrderId,
                PurchaseOrderId = src.PurchaseOrderId,
                OnlineShortOrderNum = src.OnlineShortOrderNum,
                OrderType = src.OrderType,
                CustomerName = src.CustomerName,
                Email = src.Email,
                Phone = src.Phone,
                FOHAlias = src.FOHAlias,
                BOHAlias = src.BOHAlias,
                FloorLevel = src.FloorLevel,
                Location = src.Location,
                InventoryAction = src.InventoryAction,
                HoldLocationNotes = src.HoldLocationNotes,
                ShippingAddress = src.ShippingAddress,
                Wrapped = src.Wrapped,
                Affiliation = src.Affiliation,
                SkuItems = src.SkuItems?.Select(s => SkuItem.FromNotificationSkuItem(s))?.ToArray(),
            };
    }
}
