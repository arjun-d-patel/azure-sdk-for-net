// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Represents the response to a list server metrics request. </summary>
    internal partial class ServerUsageListResult
    {
        /// <summary> Initializes a new instance of <see cref="ServerUsageListResult"/>. </summary>
        /// <param name="value"> The list of server metrics for the server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ServerUsageListResult(IEnumerable<SqlServerUsage> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ServerUsageListResult"/>. </summary>
        /// <param name="value"> The list of server metrics for the server. </param>
        internal ServerUsageListResult(IReadOnlyList<SqlServerUsage> value)
        {
            Value = value;
        }

        /// <summary> The list of server metrics for the server. </summary>
        public IReadOnlyList<SqlServerUsage> Value { get; }
    }
}
