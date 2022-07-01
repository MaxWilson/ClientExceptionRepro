// <copyright file="DynamicKitRequestByPSA.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.DynamicKit
{
    using System.Collections.Generic;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <inheritdoc/>
    public class DynamicKitRequestByPSA : Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicKitRequestByPSA"/> class.
        /// </summary>
        /// <param name="psaList">psaList.</param>
        public DynamicKitRequestByPSA(List<string> psaList)
        {
            this.PSAList = psaList;
        }

        /// <summary>
        /// Gets BigId to search Dynamic Kit.
        /// </summary>
        public List<string> PSAList { get; private set; }
    }
}
