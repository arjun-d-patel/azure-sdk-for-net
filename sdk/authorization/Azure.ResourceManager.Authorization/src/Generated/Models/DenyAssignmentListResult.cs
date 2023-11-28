// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Deny assignment list operation result. </summary>
    internal partial class DenyAssignmentListResult
    {
        /// <summary> Initializes a new instance of <see cref="DenyAssignmentListResult"/>. </summary>
        internal DenyAssignmentListResult()
        {
            Value = new ChangeTrackingList<DenyAssignmentData>();
        }

        /// <summary> Initializes a new instance of <see cref="DenyAssignmentListResult"/>. </summary>
        /// <param name="value"> Deny assignment list. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal DenyAssignmentListResult(IReadOnlyList<DenyAssignmentData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Deny assignment list. </summary>
        public IReadOnlyList<DenyAssignmentData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
