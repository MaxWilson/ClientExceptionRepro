// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResendEmailReceiptRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   The ResendEmailReceiptRequest class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Microsoft.MSE.D365.Library.EmailReceipt
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    [DataContract]
    public sealed class ResendEmailReceiptRequest : Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResendEmailReceiptRequest"/> class.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <param name="salesTransaction">transaction.</param>
        public ResendEmailReceiptRequest(SalesTransaction salesTransaction, string emailAddress)
        {
            ThrowIf.Null(salesTransaction, nameof(salesTransaction));
            ThrowIf.NullOrWhiteSpace(emailAddress, nameof(emailAddress));

            this.EmailAddress = emailAddress;
            this.SalesTransaction = salesTransaction;
        }

        /// <summary>
        /// Gets the transaction identifier.
        /// </summary>
        /// <value>
        /// The transaction identifier.
        /// </value>
        [DataMember]
        public SalesTransaction SalesTransaction { get; private set; }

        /// <summary>
        /// Gets the email address.
        /// </summary>
        /// <value>
        /// The email address.
        /// </value>
        [DataMember]
        public string EmailAddress { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the channel should be retrieved from principal for the specific request.
        /// </summary>
        public override bool NeedChannelIdFromPrincipal => false;
    }
}
