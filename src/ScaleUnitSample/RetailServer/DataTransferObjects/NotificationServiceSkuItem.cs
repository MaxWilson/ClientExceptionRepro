// <copyright file="SkuItem.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions.OData
{
    public partial class NotificationServiceSkuItem
    {
        // expose this enum for reference, but we still want it to show up in $metadata as an int (not a string) so SkuItem still exposes an int instead of an enum
        public enum RetailItemStatusEnum
        {
            Default = 0,
            Confirm = 1,
            Decline = 2,
        }

        public string Id { get; set; }

        public string LineItemId { get; set; }

        public string SkuName { get; set; }

        public string SkuDescription { get; set; }

        public int Quanitity { get; set; }

        public int ItemStatus { get; set; }

        public string CancelReason { get; set; }

        public string RunnerRequestId { get; set; }

        public RunnerRequest RunnerRequest { get; set; }
    }
}
