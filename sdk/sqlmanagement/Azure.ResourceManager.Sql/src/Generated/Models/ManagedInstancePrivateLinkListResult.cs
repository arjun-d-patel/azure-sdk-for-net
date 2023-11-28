// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class ManagedInstancePrivateLinkListResult
    {
        /// <summary> Initializes a new instance of <see cref="ManagedInstancePrivateLinkListResult"/>. </summary>
        internal ManagedInstancePrivateLinkListResult()
        {
            Value = new ChangeTrackingList<ManagedInstancePrivateLinkData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstancePrivateLinkListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ManagedInstancePrivateLinkListResult(IReadOnlyList<ManagedInstancePrivateLinkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedInstancePrivateLinkData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
