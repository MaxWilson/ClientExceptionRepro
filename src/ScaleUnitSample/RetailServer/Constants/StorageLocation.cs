// <copyright file="OnlineSalesLinesUpdateRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.OnlineOrder
{
    using System;

    /// <summary>
    ///  An enumeration used to indicate the location of the storage.
    /// </summary>
    [Flags]
    public enum StorageLocation
    {
        Channel = 1,

        HQ = 2,

        All = 4,
    }
}
