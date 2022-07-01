// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DfsLookupCriteria.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   Lookup criteria for the DFS customer lookup.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.Library.DellFinanceService.DFS.DataModel.LookupCustomer
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Lookup criteria for the DFS customer lookup.
    /// </summary>
    [DataContract]
    public sealed class DfsLookupCriteria
    {
        /// <summary>
        /// Gets or sets the last four digits of the social security number.
        /// </summary>
        [DataMember]
        public string SsnLastFourDigits { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        [DataMember]
        public string PostalCode { get; set; }
    }
}