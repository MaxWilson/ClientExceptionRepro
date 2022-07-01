// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeToContentRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   The CodeToContentRequest class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Microsoft.MSE.D365.Library.CodeToContent
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    [DataContract]
    public sealed class CodeToContentRequest : Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeToContentRequest"/> class.
        /// </summary>
        /// <param name="token">The CodeToContent token.</param>
        public CodeToContentRequest(string token)
        {
            ThrowIf.NullOrWhiteSpace(token, nameof(token));

            this.Token = token;
        }

        /// <summary>
        /// Gets the CodeToContent token.
        /// </summary>
        /// <value>
        /// The CodeToContent token.
        /// </value>
        [DataMember]
        public string Token { get; private set; }
    }
}
