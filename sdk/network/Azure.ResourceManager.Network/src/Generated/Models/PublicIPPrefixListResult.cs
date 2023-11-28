// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListPublicIpPrefixes API service call. </summary>
    internal partial class PublicIPPrefixListResult
    {
        /// <summary> Initializes a new instance of <see cref="PublicIPPrefixListResult"/>. </summary>
        internal PublicIPPrefixListResult()
        {
            Value = new ChangeTrackingList<PublicIPPrefixData>();
        }

        /// <summary> Initializes a new instance of <see cref="PublicIPPrefixListResult"/>. </summary>
        /// <param name="value"> A list of public IP prefixes that exists in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal PublicIPPrefixListResult(IReadOnlyList<PublicIPPrefixData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of public IP prefixes that exists in a resource group. </summary>
        public IReadOnlyList<PublicIPPrefixData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
