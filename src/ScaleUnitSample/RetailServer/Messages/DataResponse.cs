// <copyright file="DataResponse.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.RetailServer.Extensions
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    public class DataResponse<T> : Response
    {
        public DataResponse(T item)
        {
            this.Item = item;
        }

        public T Item { get; }
    }

    public static class DataResponse
    {
        public static DataResponse<T> Create<T>(T item) => new DataResponse<T>(item);
    }
}
