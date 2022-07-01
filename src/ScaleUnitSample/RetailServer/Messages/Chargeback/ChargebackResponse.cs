// <copyright file="ChargebackResponse.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.Chargeback
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using System.Runtime.Serialization;

    /// <summary>
    /// Contains the response from the chargeback request API.
    /// </summary>
    [DataContract]
    public class ChargebackResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargebackResponse"/> class.
        /// </summary>
        /// <param name="salesId">The sales ID of the order associated with the revenue of this chargeback.</param>
        /// <param name="successful">Whether or not the request was successfully processed.</param>
        /// <param name="message">Any detailed message to return to the caller.</param>
        public ChargebackResponse(string salesId, bool successful, string message)
        {
            this.SalesId = salesId;
            this.Successful = successful;
            this.Message = message;
        }

        /// <summary>
        /// Gets the sales ID that was created for the chargeback.
        /// </summary>
        [DataMember(Name= "salesId")]
        public string SalesId { get; private set; }

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
