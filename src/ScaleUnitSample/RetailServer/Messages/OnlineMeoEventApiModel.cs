// <copyright file="OnlineMeoEventApiModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.OnlineEmail.MEO
{
    using Newtonsoft.Json;

    /// <summary>
    ///    Represents the MEO email data model for Event Grid.
    /// </summary>
    public class OnlineMeoEventApiModel
    {
        /// <summary>
        /// Gets or sets the recipient email id.
        /// </summary>
        [JsonProperty("Email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets event id.
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId { get; set; }

        /// <summary>
        /// Gets or sets the event culture.
        /// </summary>
        [JsonProperty("Culture")]
        public string Culture { get; set; }

        /// <summary>
        /// Gets or sets the subscriptionId.
        /// </summary>
        [JsonProperty("SubscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets input paramters.
        /// </summary>
        [JsonProperty("Values")]
        public object Values { get; set; }

        /// <summary>
        /// Gets or sets the messageId.
        /// </summary>
        [JsonProperty("EventRequestId")]
        public string EventRequestId { get; set; }
    }
}
