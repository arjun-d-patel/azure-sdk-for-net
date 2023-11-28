// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.WebPubSub;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> A list of shared private link resources. </summary>
    internal partial class SharedPrivateLinkResourceList
    {
        /// <summary> Initializes a new instance of <see cref="SharedPrivateLinkResourceList"/>. </summary>
        internal SharedPrivateLinkResourceList()
        {
            Value = new ChangeTrackingList<WebPubSubSharedPrivateLinkData>();
        }

        /// <summary> Initializes a new instance of <see cref="SharedPrivateLinkResourceList"/>. </summary>
        /// <param name="value"> The list of the shared private link resources. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of private endpoint connections. Returned when the total number of requested private endpoint connections exceed maximum page size. </param>
        internal SharedPrivateLinkResourceList(IReadOnlyList<WebPubSubSharedPrivateLinkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of the shared private link resources. </summary>
        public IReadOnlyList<WebPubSubSharedPrivateLinkData> Value { get; }
        /// <summary> Request URL that can be used to query next page of private endpoint connections. Returned when the total number of requested private endpoint connections exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
