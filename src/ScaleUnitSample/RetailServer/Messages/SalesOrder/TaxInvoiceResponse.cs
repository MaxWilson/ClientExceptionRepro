// <copyright file="TaxInvoiceRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.Tax
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// Contains the request data from the tax invoice request API.
    /// </summary>
    [DataContract]
    public class TaxInvoiceResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxInvoiceResponse"/> class.
        /// </summary>
        /// <param name="message">Any extra data to return to the caller, such as a stack track or other details.</param>
        /// <param name="successful">Whether or not the request was successfully processed.</param>
        public TaxInvoiceResponse(string message, bool successful)
        {
            this.Message = message;
            this.Successful = successful;
        }

        /// <summary>
        /// Gets a value indicating whether the request was succesfully processed.
        /// </summary>
        [DataMember(Name = "successful")]
        public bool Successful { get; private set; }

        /// <summary>
        /// Gets status message for the request with any execution details.
        /// </summary>
        [DataMember(Name = "message")]
        public string Message { get; private set; }
    }
}
