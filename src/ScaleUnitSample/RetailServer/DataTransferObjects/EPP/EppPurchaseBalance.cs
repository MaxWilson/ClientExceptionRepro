// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EppPurchaseBalance.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   Class to represent the purchase balance of an employee.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Microsoft.MSE.D365.Library.EPP
{
    using System;
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.ComponentModel.DataAnnotations;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;

    /// <summary>
    /// Class to represent the purchase balance of an employee.
    /// </summary>
    public class EppPurchaseBalance : CommerceEntity
    {
        private const string BalanceAmountTypeColumn = "BalanceAmountType";
        private const string BalanceTypeColumn = "BalanceType";
        private const string EmployeeIdColumn = "EmployeeId";
        private const string OriginalBalanceColumn = "OriginalBalance";

        /// <summary>
        /// Initializes a new instance of the <see cref="EppPurchaseBalance"/> class.
        /// </summary>
        public EppPurchaseBalance()
            : base(nameof(EppPurchaseBalance))
        {
        }

        /// <summary>
        /// Gets or sets amount of money.
        /// </summary>
        [DataMember]
        [Column(BalanceAmountTypeColumn)]
        public string BalanceAmountType
        {
            get { return (string)this[BalanceAmountTypeColumn]; }
            set { this[BalanceAmountTypeColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the type of balance.
        /// </summary>
        [DataMember]
        [Column(BalanceTypeColumn)]
        public string BalanceType
        {
            get { return (string)this[BalanceTypeColumn]; }
            set { this[BalanceTypeColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the id of the employee whose balance was requested.
        /// </summary>
        [DataMember]
        [Key]
        [System.ComponentModel.DataAnnotations.Key]
        [Column(EmployeeIdColumn)]
        public string EmployeeId
        {
            get { return this[EmployeeIdColumn].ToString(); }
            set { this[EmployeeIdColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the remaining balance of the employee in US Dollars.
        /// </summary>
        [DataMember]
        [Column(OriginalBalanceColumn)]
        public decimal OriginalBalance
        {
            get
            {
                return Convert.ToDecimal(this[OriginalBalanceColumn].ToString());
            }

            set
            {
                this[OriginalBalanceColumn] = value;
            }
        }
    }
}
