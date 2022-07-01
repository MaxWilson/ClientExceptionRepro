// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeToContentResponse.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   The CodeToContentResponse class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Microsoft.MSE.D365.Library.CodeToContent
{
    using System.Runtime.Serialization;
    using LOE.Common.Entities.V3_1;
    using Microsoft.Dynamics.Commerce.Runtime;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    [DataContract]
    public sealed class CodeToContentResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeToContentResponse"/> class.
        /// </summary>
        /// <param name="tokenInfo">The tokeninfo.</param>
        public CodeToContentResponse(TokenInfo tokenInfo)
        {
            ThrowIf.Null(tokenInfo, nameof(tokenInfo));

            this.TokenInfo = tokenInfo;
        }

        /// <summary>
        /// Gets the tokeninfo.
        /// </summary>
        /// <value>
        /// The tokeninfo.
        /// </value>
        [DataMember]
        public TokenInfo TokenInfo { get; private set; }
    }
}
