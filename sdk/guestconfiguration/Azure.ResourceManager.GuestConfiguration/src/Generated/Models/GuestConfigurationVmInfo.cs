// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Information about the VM. </summary>
    public partial class GuestConfigurationVmInfo
    {
        /// <summary> Initializes a new instance of <see cref="GuestConfigurationVmInfo"/>. </summary>
        public GuestConfigurationVmInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationVmInfo"/>. </summary>
        /// <param name="id"> Azure resource Id of the VM. </param>
        /// <param name="uuid"> UUID(Universally Unique Identifier) of the VM. </param>
        internal GuestConfigurationVmInfo(ResourceIdentifier id, Guid? uuid)
        {
            Id = id;
            Uuid = uuid;
        }

        /// <summary> Azure resource Id of the VM. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> UUID(Universally Unique Identifier) of the VM. </summary>
        public Guid? Uuid { get; }
    }
}
