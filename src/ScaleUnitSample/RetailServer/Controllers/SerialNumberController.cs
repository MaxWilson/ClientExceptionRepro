// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerialNumberController.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   Defines the SerialNumberController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.RetailServer.Extensions
{
    using System;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;
    using global::MSE.D365.Library.SerialNumber;
    using global::MSE.D365.Library.Telemetry;
    using Microsoft.Dynamics.Commerce.Runtime;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    [ComVisible(false)]
    [RoutePrefix("SerialNumber")]
    [BindEntity(typeof(SerialNumber))]
    public class SerialNumberController : IController
    {

        /// <summary>
        /// The controller to validate serial number, required parameters are ItemId,SerialNumber.
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="itemId"></param>
        /// <param name="serialNumber"></param>
        /// <returns>Status of that serial number.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<SerialValidationStatus> ValidateSerialNumber(IEndpointContext ctx, string itemId, string serialNumber)
        {
            ThrowIf.Null(itemId, "ValidateSerialNumber parameters");
            ThrowIf.Null(serialNumber, "ValidateSerialNumber parameters");
            return (await ctx.ExecuteAsync<DataResponse<SerialValidationStatus>>(new SerialNumberRequest(itemId, serialNumber)).ConfigureAwait(false)).Item;
        }
    }
}
