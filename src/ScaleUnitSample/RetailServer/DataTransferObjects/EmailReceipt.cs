// <copyright file="EmailReceipt.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.EmailReceipt
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.ComponentModel.DataAnnotations;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;

    public class EmailReceipt : CommerceEntity
    {
        private const string TransactionIdColumn = "TransactionId";
        private const string EmailAddressColumn = "EmailAddress";

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailReceipt"/> class.
        /// </summary>
        public EmailReceipt()
            : base(nameof(EmailReceipt))
        {
        }

        [DataMember]
        [Key]
        [Column(TransactionIdColumn)]
        public string Id
        {
            get { return (string)this[TransactionIdColumn]; }
            set { this[TransactionIdColumn] = value; }
        }

        [DataMember]
        [Column(EmailAddressColumn)]
        public string EmailAddress
        {
            get { return (string)this[EmailAddressColumn]; }
            set { this[EmailAddressColumn] = value; }
        }
    }
}
