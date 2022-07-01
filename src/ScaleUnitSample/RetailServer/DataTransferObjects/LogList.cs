// <copyright file="LogList.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.Telemetry
{
    using System.Collections.Generic;

    public class LogList
    {
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the log details.
        /// </summary>
        public List<LogEntry> LogDetails { get; set; }
    }
}