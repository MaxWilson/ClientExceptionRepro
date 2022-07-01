// <copyright file="AffiliationInfo.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.MSE.D365.Library.EPP
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The affiliation info class.
    /// </summary>
    [DataContract]
    public class AffiliationInfo
    {
        /// <summary>
        /// Gets or sets the affiliation identifier.
        /// </summary>
        [DataMember]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the affiliation name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
    }
}
