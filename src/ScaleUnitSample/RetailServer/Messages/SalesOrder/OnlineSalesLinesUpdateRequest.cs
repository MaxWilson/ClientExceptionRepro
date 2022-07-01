// <copyright file="OnlineSalesLinesUpdateRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.OnlineOrder
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using Microsoft.MSE.D365.Library;
    using Newtonsoft.Json;

    /// <summary>
    /// Online SalesLines Update Request.
    /// </summary>
    [DataContract]
    public class OnlineSalesLinesUpdateRequest : Request
    {
        /// <summary>
        /// Gets or sets the OnlineSalesLineUpdateRequest List.
        /// </summary>
        [JsonProperty("OnlineSalesLineUpdateRequestList")]
        public List<OnlineSalesLineUpdateRequest> OnlineSalesLineUpdateRequestList { get; set; }

        /// <summary>
        /// Gets or sets the StorageLocation.
        /// </summary>
        [JsonProperty("StorageLocation")]
        public StorageLocation StorageLocation { get; set; }
    }
}
