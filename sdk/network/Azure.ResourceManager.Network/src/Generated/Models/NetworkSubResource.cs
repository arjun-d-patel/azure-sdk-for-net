// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Reference to another subresource. </summary>
    public partial class NetworkSubResource
    {
        /// <summary> Initializes a new instance of <see cref="NetworkSubResource"/>. </summary>
        public NetworkSubResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSubResource"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        internal NetworkSubResource(ResourceIdentifier id)
        {
            Id = id;
        }

        /// <summary> Resource ID. </summary>
        public ResourceIdentifier Id { get; set; }
    }
}
