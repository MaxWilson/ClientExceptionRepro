// <copyright file="SerialNumber.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.SerialNumber
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.ComponentModel.DataAnnotations;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;

    public class SerialNumber : CommerceEntity
    {
        private const string SerialNumberColumn = "SerialNumber";
        private const string ItemIdColumn = "ItemId";

        /// <summary>
        /// Initializes a new instance of the <see cref="SerialNumber"/> class.
        /// </summary>
        public SerialNumber()
            : base(nameof(SerialNumber))
        {
        }

        [DataMember]
        [Key]
        [System.ComponentModel.DataAnnotations.Key]
        [Column(ItemIdColumn)]
        public string Id
        {
            get { return (string)this[ItemIdColumn]; }
            set { this[ItemIdColumn] = value; }
        }

        [DataMember]
        [Column(SerialNumberColumn)]
        public string SerialNumberValue
        {
            get { return (string)this[SerialNumberColumn]; }
            set { this[SerialNumberColumn] = value; }
        }
    }
}
