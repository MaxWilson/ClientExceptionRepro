// <copyright file="AbandonedCartResponse.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace MSE.D365.Library.CartExport
{
    using System.Collections.Generic;
    using MSE.D365.Library.OnlineEmail.EmailConfirmation;

    /// <summary>
    /// AbandonedCartResponse class.
    /// </summary>
    public class AbandonedCartResponse
    {
        /// <summary>
        /// Gets or Sets CartSearchResults.
        /// </summary>
        public List<StoreEmailEvent> CartSearchResults { get; set; }

        /// <summary>
        /// Gets or Sets AbandonedCartResults.
        /// </summary>
        public List<AbandonedCartResult> AbandonedCartResults { get; set; }
    }
}
