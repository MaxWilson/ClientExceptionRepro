// <copyright file="KitLineItem.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.DynamicKit
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;

    /// <summary>
    /// Line item level information for dynamic kit.
    /// </summary>
    public class KitLineItem : CommerceEntity
    {
        public KitLineItem() : base("KitLineItem")
        {
        }

        /// <summary>
        /// Gets or sets Kit type (i.e. Static, Dynamic, BuyMGetN) information.
        /// </summary>
        public int DynamicKitType
        {
            get { return (int)this["DynamicKitType"]; }
            set { this["DynamicKitType"] = value; }
        }

        /// <summary>
        /// Gets or sets the value of SlotId.
        /// </summary>
        public int SlotId
        {
            get { return (int)this["SlotId"]; }
            set { this["SlotId"] = value; }
        }

        /// <summary>
        /// Gets or sets the information related to minimum number of products which needs to be selected in this slot.
        /// </summary>
        public int Minimum
        {
            get { return (int)this["Minimum"]; }
            set { this["Minimum"] = value; }
        }

        /// <summary>
        /// Gets or sets the information related to maximum number of products which can to be selected in this slot.
        /// </summary>
        public int Maximum
        {
            get { return (int)this["Maximum"]; }
            set { this["Maximum"] = value; }
        }

        /// <summary>
        /// Gets or sets the value of render hint for this slot.
        /// </summary>
        public int KitGroupRenderHint
        {
            get { return (int)this["KitGroupRenderHint"]; }
            set { this["KitGroupRenderHint"] = value; }
        }

        /// <summary>
        /// Gets or sets PSA of the line item.
        /// </summary>
        public string PSA
        {
            get { return (string)this["PSA"]; }
            set { this["PSA"] = value; }
        }

        /// <summary>
        /// Gets or sets the Tag value (if any) of the line item.
        /// </summary>
        public string Tag
        {
            get { return (string)this["Tag"]; }
            set { this["Tag"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether line item needs to be autoselected in the dynamic kit or not.
        /// </summary>
        public bool AutoSelected
        {
            get { return Convert.ToBoolean((int)this["AutoSelected"]); }
            set { this["AutoSelected"] = value; }
        }

        /// <summary>
        /// Gets or sets the MSRP value of the line item.
        /// </summary>
        public decimal MSRP
        {
            get { return (decimal)this["MSRP"]; }
            set { this["MSRP"] = value; }
        }

        /// <summary>
        /// Gets or sets the ListPrice value of the line item.
        /// </summary>
        public decimal ListPrice
        {
            get { return (decimal)this["ListPrice"]; }
            set { this["ListPrice"] = value; }
        }

        /// <summary>
        /// Gets or sets the SapSkuId value (if any) of the line item.
        /// </summary>
        public string SapSkuId
        {
            get { return (string)this["SapSkuId"]; }
            set { this["SapSkuId"] = value; }
        }

        /// <summary>
        /// Gets or sets the SapSkuId value (if any) of the line item.
        /// </summary>
        [Key]
        public long RecordId
        {
            get { return (long)this["RecId"]; }
            set { this["RecId"] = value; }
        }

        /// <summary>
        /// Gets or sets the BundleId value of the line item.
        /// </summary>
        public string BundleId
        {
            get { return (string)this["BundleId"]; }
            set { this["BundleId"] = value; }
        }

        /// <summary>
        /// Gets or sets the ExclusionProperties value of the line item.
        /// </summary>
        public string ExclusionProperties
        {
            get { return (string)this["ExclusionProperties"]; }
            set { this["ExclusionProperties"] = value; }
        }

        /// <summary>
        /// Gets or sets the InclusionProperties value of the line item.
        /// </summary>
        public string InclusionProperties
        {
            get { return (string)this["InclusionProperties"]; }
            set { this["InclusionProperties"] = value; }
        }

        /// <summary>
        /// Gets or sets the ProductId value of the line item.
        /// </summary>
        public long ProductId
        {
            get { return (long)this["ProductId"]; }
            set { this["ProductId"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether IsPreOrder eligible or not.
        /// </summary>
        public bool IsPreOrder
        {
            get { return Convert.ToBoolean((int)this["IsPreOrder"]); }
            set { this["IsPreOrder"] = value; }
        }
    }
}
