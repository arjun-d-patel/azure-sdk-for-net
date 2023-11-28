// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The response of list relationship link operation. </summary>
    internal partial class RelationshipLinkListResult
    {
        /// <summary> Initializes a new instance of <see cref="RelationshipLinkListResult"/>. </summary>
        internal RelationshipLinkListResult()
        {
            Value = new ChangeTrackingList<RelationshipLinkResourceFormatData>();
        }

        /// <summary> Initializes a new instance of <see cref="RelationshipLinkListResult"/>. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal RelationshipLinkListResult(IReadOnlyList<RelationshipLinkResourceFormatData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<RelationshipLinkResourceFormatData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
