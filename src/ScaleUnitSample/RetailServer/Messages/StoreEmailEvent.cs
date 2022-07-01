// <copyright file="StoreEmailEvent.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.OnlineEmail.EmailConfirmation
{
    using MSE.D365.Library.OnlineEmail.MEO;
    using Newtonsoft.Json;
    using System;

    /// <summary>
    ///    Represents the email data model for Event Grid.
    /// </summary>
    public class StoreEmailEvent
    {
        /// <summary>
        /// Gets or sets a value indicating the CorrelationId of the request.
        /// </summary>
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the UserId of the request.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the datetime of the sending source of an email message.
        /// </summary>
        public DateTime SourceDateTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the recipients email address.
        /// </summary>
        public string RecipientEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the message data of an email message.
        /// </summary>
        public object MessageData { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the Template Id of an email message.
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the Cart Id of an email message.
        /// </summary>
        public string CartId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the Data Area Id of an email message.
        /// </summary>
        public string DataAreaId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsMEOTemplate of an email message.
        /// </summary>
        [JsonProperty("IsMEOTemplate")]
        public bool IsMEOTemplate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the Data Area Id of an email message.
        /// </summary>
        public OnlineMeoEventApiModel OnlineMeoEventApiModel { get; set; }
    }
}
