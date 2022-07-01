// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EppPurchases.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   Class to represent the purchases of an employee.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Microsoft.MSE.D365.Library.EPP
{
    using System.Collections.Generic;

    // <summary>
    // Class containing properties of EPP purchase.
    // </summary>
    public class EppPurchases
    {
        // <summary>
        // Gets or sets the balance type of the Epp purchase.
        // </summary>
        public string BalanceType => "EPP";

        // <summary>
        // Gets or sets the Order number of the Epp purchase.
        // </summary>
        public string OrderNumber { get; set; }

        // <summary>
        // Gets or sets the Store of the Epp purchase.
        // </summary>
        public string Store => "MSRetailStore";

        // <summary>
        // Gets or sets the list of EPP purchase items.
        // </summary>
        public List<EppPurchaseItem> Items { get; set; }
    }
}