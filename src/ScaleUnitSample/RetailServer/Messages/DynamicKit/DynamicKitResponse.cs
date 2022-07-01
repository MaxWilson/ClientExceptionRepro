// <copyright file="DynamicKitResponse.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.DynamicKit
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// Dynamic Kit Response Class.
    /// </summary>
    [DataContract]
    public sealed class DynamicKitResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicKitResponse"/> class.
        /// </summary>
        /// <param name="kit">DynamicKit.</param>
        public DynamicKitResponse(List<KitLineItem> kit)
        {
            this.DynamicKit = kit;
        }

        /// <summary>
        /// Gets dynamicKit Product document.
        /// </summary>
        [DataMember]
        public List<KitLineItem> DynamicKit { get; private set; }
    }
}
