// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DfsCustomer.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   The data contract class for DFS customer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.Library.DellFinanceService.DFS.DataModel.LookupCustomer
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.ComponentModel.DataAnnotations;

    /// <summary>
    /// The data contract class for DFS customer.
    /// </summary>
    [DataContract]
    public class DfsCustomer
    {
        /// <summary>
        /// Gets or sets the account network type.
        /// </summary>
        [DataMember]
        public string AccountNetworkType { get; set; }

        /// <summary>
        /// Gets or sets the account number of customer.
        /// </summary>
        [DataMember]
        [Key]
        [System.ComponentModel.DataAnnotations.Key]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the account reference id of customer.
        /// </summary>
        [DataMember]
        public string AccountReferenceId { get; set; }

        /// <summary>
        /// Gets or sets first line of customer address.
        /// </summary>
        [DataMember]
        public string AddressLineOne { get; set; }

        /// <summary>
        /// Gets or sets second line of customer address.
        /// </summary>
        [DataMember]
        public string AddressLineTwo { get; set; }

        /// <summary>
        /// Gets or sets the city of the customer.
        /// </summary>
        [DataMember]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the decision description.
        /// </summary>
        [DataMember]
        public string DecisionDescription { get; set; }

        /// <summary>
        /// Gets or sets the decision type.
        /// </summary>
        [DataMember]
        public string DecisionType { get; set; }

        /// <summary>
        /// Gets or sets the error message, useful when lookup is not successful.
        /// </summary>
        [DataMember]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the first name of the customer.
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the customer.
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the lender contact id.
        /// </summary>
        [DataMember]
        public string LenderContactId { get; set; }

        /// <summary>
        /// Gets or sets the lender contact name.
        /// </summary>
        [DataMember]
        public string LenderContactName { get; set; }

        /// <summary>
        /// Gets or sets the lender name of customer.
        /// </summary>
        [DataMember]
        public string LenderName { get; set; }

        /// <summary>
        /// Gets or sets the network type of customer.
        /// </summary>
        [DataMember]
        public string NetworkType { get; set; }

        /// <summary>
        /// Gets or sets the open credit limit of customer.
        /// </summary>
        [DataMember]
        public decimal OpenCreditLimit { get; set; }

        /// <summary>
        /// Gets or sets the postal code of customer.
        /// </summary>
        [DataMember]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the state code of customer.
        /// </summary>
        [DataMember]
        public string StateCode { get; set; }
    }
}