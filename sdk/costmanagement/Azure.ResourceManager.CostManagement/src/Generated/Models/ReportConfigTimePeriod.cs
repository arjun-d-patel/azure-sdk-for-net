// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The start and end date for pulling data for the report. </summary>
    public partial class ReportConfigTimePeriod
    {
        /// <summary> Initializes a new instance of <see cref="ReportConfigTimePeriod"/>. </summary>
        /// <param name="from"> The start date to pull data from. </param>
        /// <param name="to"> The end date to pull data to. </param>
        public ReportConfigTimePeriod(DateTimeOffset @from, DateTimeOffset to)
        {
            From = @from;
            To = to;
        }

        /// <summary> The start date to pull data from. </summary>
        public DateTimeOffset From { get; set; }
        /// <summary> The end date to pull data to. </summary>
        public DateTimeOffset To { get; set; }
    }
}
