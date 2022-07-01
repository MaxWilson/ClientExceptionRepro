// <copyright file="SkuItem.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions.OData
{
    public partial class SkuItem
    {
        // expose this enum for reference, but we still want it to show up in $metadata as an int (not a string) so SkuItem still exposes an int instead of an enum
        public enum RetailItemStatusEnum
        {
            Default = 0,
            Confirm = 1,
            Decline = 2,
        }

        // It's important not to name this Id or SkuItemId, or else the framework will think it's an entity type and will not serialize the SkuItems
        public string SkuItemRecordId { get; set; }

        public string LineItemId { get; set; }

        public string SkuName { get; set; }

        public string SkuDescription { get; set; }

        public int Quantity { get; set; }

        public int ItemStatus { get; set; }

        public string CancelReason { get; set; }

        public string RunnerRequestId { get; set; }

        public NotificationServiceSkuItem ToNotificationSkuItem() =>
            new NotificationServiceSkuItem
            {
                Id = this.SkuItemRecordId,
                LineItemId = this.LineItemId,
                SkuName = this.SkuName,
                SkuDescription = this.SkuDescription,
                Quanitity = this.Quantity,
                ItemStatus = this.ItemStatus,
                CancelReason = this.CancelReason,
                RunnerRequestId = this.RunnerRequestId,
            };
        public static SkuItem FromNotificationSkuItem(NotificationServiceSkuItem src) =>
            src == null ? null :
            new SkuItem
            {
                SkuItemRecordId = src.Id,
                LineItemId = src.LineItemId,
                SkuName = src.SkuName,
                SkuDescription = src.SkuDescription,
                Quantity = src.Quanitity,
                ItemStatus = src.ItemStatus,
                CancelReason = src.CancelReason,
                RunnerRequestId = src.RunnerRequestId,
            };
    }
}
