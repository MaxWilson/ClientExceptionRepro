// <copyright file="OnlineSalesLinesUpdateResponse.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace MSE.D365.Library.OnlineOrder
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// Online SalesLinesUpdateResponse response class.
    /// </summary>
    [DataContract]
    public class OnlineSalesLinesUpdateResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineSalesLinesUpdateResponse"/> class.
        /// </summary>
        /// <param name="salesOrder">Sales Order data object.</param>
        public OnlineSalesLinesUpdateResponse(SalesOrder salesOrder)
        {
            this.SalesOrder = salesOrder;
        }

        /// <summary>
        /// Gets sales Order data object.
        /// </summary>
        [DataMember]
        public SalesOrder SalesOrder { get; private set; }
    }
}
