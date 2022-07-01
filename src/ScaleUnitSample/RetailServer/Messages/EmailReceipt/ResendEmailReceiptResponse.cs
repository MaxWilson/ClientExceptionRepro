// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResendEmailReceiptResponse.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   The ResendEmailReceiptResponse class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Microsoft.MSE.D365.Library.EmailReceipt
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    [DataContract]
    public class ResendEmailReceiptResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResendEmailReceiptResponse"/> class.
        /// </summary>
        /// <param name="success">if set to <c>true</c> [success].</param>
        /// <param name="salesTransaction"></param>
        public ResendEmailReceiptResponse(bool success, SalesTransaction salesTransaction)
        {
            this.Success = success;
            this.SalesTransaction = salesTransaction;
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="ResendEmailReceiptResponse"/> is success.
        /// </summary>
        /// <value>
        ///   <c>true</c> if success; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool Success { get; private set; }

        /// <summary>
        /// Gets the sales transaction.
        /// </summary>
        /// <value>
        /// The sales transaction.
        /// </value>
        [DataMember]
        public SalesTransaction SalesTransaction { get; private set; }
    }
}
