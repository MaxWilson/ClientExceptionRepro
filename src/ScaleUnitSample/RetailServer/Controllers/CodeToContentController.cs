// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeToContentController.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   Defines the CodeToContentController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.RetailServer.Extensions
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;
    using Microsoft.MSE.D365.Library.CodeToContent;
    using Newtonsoft.Json;

    /// <summary>
    /// Handles the API requests for Code To Content
    /// </summary>
    [ComVisible(false)]
    public class CodeToContentController : IController
    {
        /// <summary>
        /// C2C token format.
        /// </summary>
        public const string ESDTokenPattern = @"^(\w{5})-(\w{5})-(\w{5})-(\w{5})-(\w{5})$";

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeToContentController"/> class.
        /// </summary>
        /// </summary>
        public CodeToContentController()
        {
        }

        /// <summary>
        /// Checks the status of given C2C token.
        /// </summary>
        /// <param name="ctx">Endpoint context for accessing CRT.</param>
        /// <returns>C2C status.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Storefront, CommerceRoles.Application, CommerceRoles.Device)]
        public async Task<string> GetStatus(IEndpointContext ctx, string token)
        {
            if (token == null || !Regex.IsMatch(token, ESDTokenPattern))
            {
                throw new Exception("Invalid token received.");
            }

            var response = JsonConvert.SerializeObject((await ctx.ExecuteAsync<CodeToContentResponse>(new CodeToContentRequest(token)).ConfigureAwait(false)).TokenInfo);
            return response;
        }
    }
}
