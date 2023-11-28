// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Specifies the mapping between this particular user and the type of access he has on shares on this device. </summary>
    public partial class ShareAccessRight
    {
        /// <summary> Initializes a new instance of <see cref="ShareAccessRight"/>. </summary>
        /// <param name="shareId"> The share ID. </param>
        /// <param name="accessType"> Type of access to be allowed on the share for this user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="shareId"/> is null. </exception>
        internal ShareAccessRight(ResourceIdentifier shareId, ShareAccessType accessType)
        {
            Argument.AssertNotNull(shareId, nameof(shareId));

            ShareId = shareId;
            AccessType = accessType;
        }

        /// <summary> The share ID. </summary>
        public ResourceIdentifier ShareId { get; }
        /// <summary> Type of access to be allowed on the share for this user. </summary>
        public ShareAccessType AccessType { get; }
    }
}
