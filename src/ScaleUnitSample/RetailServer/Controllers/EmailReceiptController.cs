// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailReceiptController.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>
//   Defines the EmailReceiptController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MSE.D365.RetailServer.Extensions
{
    using System;
    using System.Net;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;
    using global::MSE.D365.Library.EmailReceipt;
    using global::MSE.D365.Library.Telemetry;
    using Microsoft.Dynamics.Commerce.Runtime;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;
    using Microsoft.Dynamics.Commerce.Runtime.Services.Messages;
    using Microsoft.MSE.D365.Library.EmailReceipt;

    [ComVisible(false)]
    [RoutePrefix("EmailReceipt")]
    [BindEntity(typeof(EmailReceipt))]
    public class EmailReceiptController : IController
    {
        private string validationMessage = string.Empty;

        [HttpPost]
        [Authorization(CommerceRoles.Employee, CommerceRoles.Device)]
        public async Task<bool> ResendEmailReceipt(IEndpointContext ctx, string transactionId, string emailAddress)
        {
            ResponseHelper.NullCheck(transactionId, nameof(transactionId));
            ResponseHelper.NullCheck(emailAddress, nameof(emailAddress));

            var loadSalesOrderRequest = new GetSalesOrderDetailsByTransactionIdServiceRequest(transactionId, SearchLocation.Local);
            var loadSalesOrderRequestResponse = await ctx.ExecuteAsync<GetSalesOrderDetailsServiceResponse>(loadSalesOrderRequest).ConfigureAwait(false);
            SalesTransaction salesOrder = loadSalesOrderRequestResponse.SalesOrder;

            if (salesOrder == null)
            {
                ResponseHelper.Fail($"No sales transaction found with transaction id {transactionId}");
            }

            ResendEmailReceiptRequest resendEmailReceiptRequest = new ResendEmailReceiptRequest(salesOrder, emailAddress);

            ResendEmailReceiptResponse resp = await ctx.ExecuteAsync<ResendEmailReceiptResponse>(resendEmailReceiptRequest).ConfigureAwait(false);

            if(resp.Success == false)
            {
                ResponseHelper.Fail("Email was not sent successfully");
            }

            return true;
        }
    }
}
