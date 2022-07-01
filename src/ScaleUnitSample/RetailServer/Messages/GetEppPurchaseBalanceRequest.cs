﻿// <copyright file="SearchCustomerCartsRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    public class GetEppPurchaseBalanceRequest : Request
    {
        public GetEppPurchaseBalanceRequest(string employeeId)
        {
            EmployeeId = employeeId;
        }

        public string EmployeeId { get; }
    }
}
