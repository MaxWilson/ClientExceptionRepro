// <copyright file="SearchCustomerCartsRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using Microsoft.Dynamics.Commerce.Runtime;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using System.Collections.Generic;

    public class OnlineStoreCheckoutRequest : Request
    {
        public OnlineStoreCheckoutRequest(string cartId, string receiptEmail, IEnumerable<CartTenderLine> cartTenderLines, TokenizedPaymentCard tokenizedPaymentCard, string receiptNumberSequence, long? cartVersion)
        {
            CartId = cartId;
            ReceiptEmail = receiptEmail;
            CartTenderLines = cartTenderLines;
            TokenizedPaymentCard = tokenizedPaymentCard;
            ReceiptNumberSequence = receiptNumberSequence;
            CartVersion = cartVersion;
        }

        public string CartId { get; }

        public string ReceiptEmail { get; }

        public IEnumerable<CartTenderLine> CartTenderLines { get; }

        public TokenizedPaymentCard TokenizedPaymentCard { get; }

        public string ReceiptNumberSequence { get; }

        public long? CartVersion { get; }
    }
}
