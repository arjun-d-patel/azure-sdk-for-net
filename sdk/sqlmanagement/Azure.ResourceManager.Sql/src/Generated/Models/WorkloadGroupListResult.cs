// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of workload groups. </summary>
    internal partial class WorkloadGroupListResult
    {
        /// <summary> Initializes a new instance of <see cref="WorkloadGroupListResult"/>. </summary>
        internal WorkloadGroupListResult()
        {
            Value = new ChangeTrackingList<WorkloadGroupData>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadGroupListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal WorkloadGroupListResult(IReadOnlyList<WorkloadGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<WorkloadGroupData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
