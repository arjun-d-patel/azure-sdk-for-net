// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Specified resource. </summary>
    public partial class TrackedResourceExtendedData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="TrackedResourceExtendedData"/>. </summary>
        /// <param name="location"> The location. </param>
        public TrackedResourceExtendedData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="TrackedResourceExtendedData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Resource extended location. </param>
        internal TrackedResourceExtendedData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
        }

        /// <summary> Resource extended location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
    }
}
