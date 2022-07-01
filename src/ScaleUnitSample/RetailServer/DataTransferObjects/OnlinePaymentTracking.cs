// <copyright file="SalesLineDetails.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.MSE.D365.Library
{
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    /// <summary>
    /// Online Payment Transaction Trackings.
    /// </summary>
    [DataContract]
    public class OnlinePaymentTracking : CommerceEntity
    {
        private const string PaymentIdColumn = "PAYMENTID";
        private const string CartIdColumn = "CARTID";
        private const string TrackingIdColumn = "TRACKINGID";
        private const string CustomerIDColumn = "CUSTOMERID";
        private const string AmountColumn = "AMOUNT";
        private const string PaymentStatusColumn = "STATUS";
        private const string CardTokenResultColumn = "CARDTOKENRESULT";
        private const string CreatedDateTimeColumn = "CREATEDDATETIME";
        private const string ModifiedDateTimeColumn = "MODIFIEDDATETIME";
        private const string ChargeIdColumn = "CHARGEID";
        /// <summary>
        /// Initializes a new instance of the <see cref="OnlinePaymentTracking"/> class.
        /// </summary>
        public OnlinePaymentTracking()
            : base("OnlinePaymentTracking")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlinePaymentTracking"/> class.
        /// </summary>
        /// <param name="entityName">name</param>
        protected OnlinePaymentTracking(string entityName)
            : base(entityName)
        {
        }

        /// <summary>
        /// Gets or sets the PaymentID.
        /// </summary>
        [Column(PaymentIdColumn)]
        [DataMember]
        public string PaymentID
        {
            get { return (string)this[PaymentIdColumn]; }
            set { this[PaymentIdColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the CartID.
        /// </summary>
        [Column(CartIdColumn)]
        [DataMember]
        public string CartID
        {
            get { return (string)this[CartIdColumn]; }
            set { this[CartIdColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the TrackingId.
        /// </summary>
        [Column(TrackingIdColumn)]
        [DataMember]
        public string TrackingID
        {
            get { return (string)this[TrackingIdColumn]; }
            set { this[TrackingIdColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the CustomerId.
        /// </summary>
        [Column(CustomerIDColumn)]
        [DataMember]
        public string CustomerID
        {
            get { return (string)this[CustomerIDColumn]; }
            set { this[CustomerIDColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the Amount.
        /// </summary>
        [Column(AmountColumn)]
        [DataMember]
        public string Amount
        {
            get { return (string)this[AmountColumn]; }
            set { this[AmountColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [Column(PaymentStatusColumn)]
        [DataMember]
        public short PaymentStatus
        {
            get { return (short)this[PaymentStatusColumn]; }
            set { this[PaymentStatusColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the Card Token Result
        /// </summary>
        [Column(CardTokenResultColumn)]
        [DataMember]
        public string CardTokenResult
        {
            get { return (string)this[CardTokenResultColumn]; }
            set { this[CardTokenResultColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the Created Date Time
        /// </summary>
        [Column(CreatedDateTimeColumn)]
        [DataMember]
        public DateTime CreatedDateTime
        {
            get { return (DateTime)this[CreatedDateTimeColumn]; }
            set { this[CreatedDateTimeColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the Modified Date Time
        /// </summary>
        [Column(ModifiedDateTimeColumn)]
        [DataMember]
        public DateTime ModifiedDateTime
        {
            get { return (DateTime)this[ModifiedDateTimeColumn]; }
            set { this[ModifiedDateTimeColumn] = value; }
        }

        public string ChargeId
        {
            get { return (string)this[ChargeIdColumn]; }
            set { this[ChargeIdColumn] = value; }
        }
    }
}