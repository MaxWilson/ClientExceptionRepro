// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EppPurchaseItem.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   Class to represent the EPP purchase item .
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Microsoft.MSE.D365.Library.EPP
{
    // <summary>
    // Class containing properties of each EPP purchase item.
    // </summary>
    public class EppPurchaseItem
    {
        /// <summary>
        /// Gets or sets the Amount of the EPP item to be purchased.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the Quantity of the EPP item to be purchased.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the Product name of the EPP item to be purchased.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the Product number of the EPP item to be purchased.
        /// </summary>
        public string ProductNumber { get; set; }

        /// <summary>
        /// Gets or sets the Product type of the EPP item to be purchased.
        /// </summary>
        public string ProductType { get; set; }
    }
}