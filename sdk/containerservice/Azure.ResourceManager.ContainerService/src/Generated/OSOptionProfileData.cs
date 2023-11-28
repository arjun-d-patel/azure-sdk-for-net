// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A class representing the OSOptionProfile data model.
    /// The OS option profile.
    /// </summary>
    public partial class OSOptionProfileData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="OSOptionProfileData"/>. </summary>
        /// <param name="osOptionPropertyList"> The list of OS options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="osOptionPropertyList"/> is null. </exception>
        internal OSOptionProfileData(IEnumerable<ContainerServiceOSOptionProperty> osOptionPropertyList)
        {
            Argument.AssertNotNull(osOptionPropertyList, nameof(osOptionPropertyList));

            OSOptionPropertyList = osOptionPropertyList.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="OSOptionProfileData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="osOptionPropertyList"> The list of OS options. </param>
        internal OSOptionProfileData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyList<ContainerServiceOSOptionProperty> osOptionPropertyList) : base(id, name, resourceType, systemData)
        {
            OSOptionPropertyList = osOptionPropertyList;
        }

        /// <summary> The list of OS options. </summary>
        public IReadOnlyList<ContainerServiceOSOptionProperty> OSOptionPropertyList { get; }
    }
}
