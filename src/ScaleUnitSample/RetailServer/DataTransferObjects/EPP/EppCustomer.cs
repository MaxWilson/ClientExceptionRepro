// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EppCustomer.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   Defines the EppCustomer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Microsoft.MSE.D365.Library.EPP
{
    using System;
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.ComponentModel.DataAnnotations;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;

    /// <summary>
    /// Class to represent the employee returned by the e-company store.
    /// </summary>
    public class EppCustomer : CommerceEntity
    {
        private const string AreaColumn = "Area";
        private const string CompanyCodeColumn = "CompanyCode";
        private const string EmployeeEmailColumn = "EmployeeEmail";
        private const string EmployeeFirstNameColumn = "EmployeeFirstName";
        private const string EmployeeIdColumn = "EmployeeId";
        private const string EmployeeLastNameColumn = "EmployeeLastName";
        private const string EmployeeNameColumn = "EmployeeName";
        private const string RolesColumn = "Roles";
        private const string EmployeePhoneColumn = "EmployeePhone";
        private const string EmployeeTypeColumn = "EmployeeType";
        private const string EventNameColumn = "EventName";
        private const string FromDateColumn = "FromDate";
        private const string ProgramColumn = "Program";
        private const string SponsorColumn = "Sponsor";
        private const string StatusColumn = "Status";
        private const string ThruDateColumn = "ThruDate";

        /// <summary>
        /// Initializes a new instance of the <see cref="EppCustomer"/> class.
        /// </summary>
        public EppCustomer()
            : base(nameof(EppCustomer))
        {
        }

        /// <summary>
        /// Gets or sets Microsoft Subsidiary Name of the employee.
        /// For non-employees, this is defaulted to "Microsoft".
        /// </summary>
        [DataMember]
        [Column(AreaColumn)]
        public string Area
        {
            get { return (string)this[AreaColumn]; }
            set { this[AreaColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the Microsoft Subsidiary Company Code of the employee.
        /// For non-employees, this is defaulted to "1010".
        /// </summary>
        [DataMember]
        [Column(CompanyCodeColumn)]
        public string CompanyCode
        {
            get { return (string)this[CompanyCodeColumn]; }
            set { this[CompanyCodeColumn] = value; }
        }

        /// <summary>
        /// Gets or sets Email Alias of MS Employees.
        /// For non-employees, this will be null if email does not exist.
        /// </summary>
        [DataMember]
        [Column(EmployeeEmailColumn)]
        public string EmployeeEmail
        {
            get { return (string)this[EmployeeEmailColumn]; }
            set { this[EmployeeEmailColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the first name of the Employee/Alumni/Passholder.
        /// </summary>
        [DataMember]
        [Column(EmployeeFirstNameColumn)]
        public string EmployeeFirstName
        {
            get { return (string)this[EmployeeFirstNameColumn]; }
            set { this[EmployeeFirstNameColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the unique identifier of the shopper eligible for EPP benefits.
        /// Can be either Employee Id, Alumni Number, VIP Store Pass Number.
        /// </summary>
        [DataMember]
        [Key]
        [System.ComponentModel.DataAnnotations.Key]
        [Column(EmployeeIdColumn)]
        public string EmployeeId
        {
            get { return (string)this[EmployeeIdColumn]; }
            set { this[EmployeeIdColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the last name of the Employee/Alumni/Passholder.
        /// </summary>
        [DataMember]

        [Column(EmployeeLastNameColumn)]
        public string EmployeeLastName
        {
            get { return (string)this[EmployeeLastNameColumn]; }
            set { this[EmployeeLastNameColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the full name of the Employee/Alumni/Passholder.
        /// </summary>
        [DataMember]
        [Column(EmployeeNameColumn)]
        public string EmployeeName
        {
            get { return (string)this[EmployeeNameColumn]; }
            set { this[EmployeeNameColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the phone number of the Employee/Alumni/Passholder.
        /// For non-employees, this will be null if phone number does not exist.
        /// </summary>
        [DataMember]
        [Column(EmployeePhoneColumn)]
        public string EmployeePhone
        {
            get { return (string)this[EmployeePhoneColumn]; }
            set { this[EmployeePhoneColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the type of benefit for which the person is eligible.
        /// </summary>
        [DataMember]
        [Column(EmployeeTypeColumn)]
        public string EmployeeType
        {
            get { return (string)this[EmployeeTypeColumn]; }
            set { this[EmployeeTypeColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the event for which the pass was registered.
        /// Valid only for pass holders.
        /// </summary>
        [DataMember]
        [Column(EventNameColumn)]
        public string EventName
        {
            get { return (string)this[EventNameColumn]; }
            set { this[EventNameColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the effective date of the Employee/Alumni/Passholder EPP benefit.
        /// </summary>
        [DataMember]
        [Column(FromDateColumn)]
        public DateTime FromDate
        {
            get { return (DateTime)this[FromDateColumn]; }
            set { this[FromDateColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the EPP Region to which the Employee/Alumni/Passholder is assigned.
        /// </summary>
        [DataMember]
        [Column(ProgramColumn)]
        public string Program
        {
            get { return (string)this[ProgramColumn]; }
            set { this[ProgramColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the list of EPP products and benefits to which the employee has access.
        /// </summary>
        [DataMember]
        [Column(RolesColumn)]
        public string[] Roles
        {
            get { return this[RolesColumn] as string[]; }
            set { this[RolesColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the sponsor Employee/Alumni EmployeeId for Friends and Family passholders.
        /// </summary>
        [DataMember]
        [Column(SponsorColumn)]
        public string Sponsor
        {
            get { return (string)this[SponsorColumn]; }
            set { this[SponsorColumn] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the Employee/Alumni/Passholder EPP benefit is active.
        /// </summary>
        [DataMember]
        [Column(StatusColumn)]
        public bool Status
        {
            get { return (bool)this[StatusColumn]; }
            set { this[StatusColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the end date of the Employee/Alumni/Passholder EPP benefit.
        /// </summary>
        [DataMember]
        [Column(ThruDateColumn)]
        public string ThruDate
        {
            get { return (string)this[ThruDateColumn]; }
            set { this[ThruDateColumn] = value; }
        }
    }
}
