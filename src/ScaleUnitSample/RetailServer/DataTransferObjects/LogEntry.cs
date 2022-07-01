// <copyright file="LogEntry.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.Telemetry
{
    using System;
    using System.Collections.Generic;

    public class LogEntry
    {
        public string Id { get; set; }

        public string Message { get; set; }

        public DateTime CreatedDatetime { get; set; }

        public List<CustomProperties> CustomPropertiesList { get; set; }

        public List<CustomMetric> CustomMetricList { get; set; }

        public int LogType { get; set; }
    }
}