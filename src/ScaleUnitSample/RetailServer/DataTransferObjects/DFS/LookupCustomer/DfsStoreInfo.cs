// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DfsStoreInfo.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   The data contract class for DFS store information.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.Library.DellFinanceService.DFS.DataModel
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Store information used for DFS authorization.
    /// </summary>
    [DataContract]
    public class DfsStoreInfo
    {
        /// <summary>
        /// Gets or sets store number.
        /// </summary>
        [DataMember]
        public string StoreNumber { get; set; }

        /// <summary>
        /// Gets or sets state code of state code.
        /// </summary>
        [DataMember]
        public string StateCode { get; set; }

        /// <summary>
        /// Gets or sets postal code of store.
        /// </summary>
        [DataMember]
        public string PostalCode { get; set; }
    }
}
