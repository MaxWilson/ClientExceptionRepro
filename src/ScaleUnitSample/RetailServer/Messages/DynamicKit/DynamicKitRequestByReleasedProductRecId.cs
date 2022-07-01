// <copyright file="DynamicKitRequestByReleasedProductRecId.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.DynamicKit
{
    using System.Collections.Generic;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <inheritdoc/>
    public class DynamicKitRequestByReleasedProductRecId : Request
   {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicKitRequestByReleasedProductRecId"/> class.
        /// </summary>
        /// <param name="releasedProductRecIds">releasedProductRecIds</param>
        public DynamicKitRequestByReleasedProductRecId(List<long> releasedProductRecIds)
        {
            this.ReleasedProductRecIds = releasedProductRecIds;
        }

        /// <summary>
        /// Gets ReleasedProductRecIds to search Dynamic Kit.
        /// </summary>
        public List<long> ReleasedProductRecIds { get; private set; }
    }
}